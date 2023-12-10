namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;
    using BondYieldCalculator.GUI.Interfaces.Services;
    using BondYieldCalculator.Parser;

    internal class LinkController : IObservableController
    {
        private readonly ILinkForm _form;
        private readonly IBondParser _bondParser;
        private readonly IYieldCalculatorService _yieldCalculatorService;
        private readonly ILinksDataGridViewController _linksDataGridViewController;
        private readonly IBondLinkRowSelectionController _bondLinkRowSelectionController;
        private readonly IList<IInfoObserverController> _subscribers;

        private List<BondInfo?> _bondInfoItems;

        public LinkController(
            ILinkForm form,
            IBondParser bondParser,
            IYieldCalculatorService yieldCalculatorService,
            ILinksDataGridViewController linksDataGridViewController,
            IBondLinkRowSelectionController bondLinkRowSelectionController)
        {
            _form = form;
            _bondParser = bondParser;
            _yieldCalculatorService = yieldCalculatorService;
            _linksDataGridViewController = linksDataGridViewController;
            _bondLinkRowSelectionController = bondLinkRowSelectionController;
            _subscribers = new List<IInfoObserverController>();
            _bondInfoItems = new List<BondInfo?>();

            _form.LinkAdded += (sender, args) => HandleLinkAdded();
            _form.LinksRemoved += (sender, args) => HandleLinksRemoved();
            _form.LinksAnalyzed += (sender, args) => HandleLinksAnalyzed();

            _bondLinkRowSelectionController.SelectionChanged += HandleSelectionChanged;
        }

        #region IObservableController Members

        public void Subcribe(IInfoObserverController subscriber) => _subscribers.Add(subscriber);

        public void Unsubscribe(IInfoObserverController subscriber) => _subscribers.Remove(subscriber);

        #endregion IObservableController Members

        #region Private Members

        private void HandleLinkAdded() => _linksDataGridViewController.AddLinkRow(_form.LinkText);

        private void HandleLinksRemoved() => _linksDataGridViewController.RemoveSelectedLinkRows();

        private void HandleLinksAnalyzed()
        {
            _form.BondPanelEnabled = false;
            _subscribers.AsParallel().ForAll(subscriber => subscriber.ClearInfo());

            var links = _linksDataGridViewController.GetLinks();
            _bondInfoItems = links
                .AsParallel()
                .Select(link => _bondParser.GetBondInfoAsync(link).Result)
                .Where(bondInfo => bondInfo is not null)
                .ToList();

            if (_bondInfoItems is null)
            {
                _bondInfoItems = new List<BondInfo?>();
                return;
            }

            _bondLinkRowSelectionController.SelectionChanged -= HandleSelectionChanged;

            foreach (var bondInfo in _bondInfoItems)
            {
                _yieldCalculatorService.UpdateYieldInfo(bondInfo);
                _linksDataGridViewController.UpdateLinkRowItem(bondInfo);
            }

            var linkRowItem = _bondLinkRowSelectionController.GetSelectedBondLinkRowItem();
            if (linkRowItem is not null)
            {
                var bondInfo = _bondInfoItems.FirstOrDefault(item => item!.Link == linkRowItem.Link);
                _subscribers.AsParallel().ForAll(subscriber => subscriber.FillInfo(bondInfo));
            }

            _bondLinkRowSelectionController.SelectionChanged += HandleSelectionChanged;

            _form.BondPanelEnabled = true;
        }

        private void HandleSelectionChanged(object? sender, EventArgs args)
        {
            _form.BondPanelEnabled = false;

            var linkRowItem = _bondLinkRowSelectionController.GetSelectedBondLinkRowItem();
            if (linkRowItem is null)
            {
                return;
            }

            var bondInfo = _bondInfoItems.FirstOrDefault(item => item!.Link == linkRowItem.Link);
            if (bondInfo is null)
            {
                return;
            }

            _subscribers.AsParallel().ForAll(subscriber => subscriber.FillInfo(bondInfo));

            _form.BondPanelEnabled = true;
        }

        #endregion Private Members
    }
}
