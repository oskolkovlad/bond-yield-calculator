namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Services;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;
    using BondYieldCalculator.Parser;

    internal class LinksManagementController : IObservableController
    {
        private readonly ILinksManagementView _linksManagementView;
        private readonly IBondParser _bondParser;
        private readonly IYieldCalculatorService _yieldCalculatorService;
        private readonly ILinksStorageService _linksStorageService;
        private readonly ILinksTableController _linksTableController;
        private readonly ILinksSelectionController _linksSelectionController;
        private readonly IControlsStateManagementController _controlsStateManagementController;
        private readonly IList<IInfoObserverController> _subscribers;

        private List<BondInfo?> _bondInfoItems;

        public LinksManagementController(
            ILinksManagementView linksManagementView,
            IBondParser bondParser,
            IYieldCalculatorService yieldCalculatorService,
            ILinksStorageService linksStorageService,
            ILinksTableController linksTableController,
            ILinksSelectionController linksSelectionController,
            IControlsStateManagementController controlsStateManagementController)
        {
            _linksManagementView = linksManagementView;
            _bondParser = bondParser;
            _yieldCalculatorService = yieldCalculatorService;
            _linksStorageService = linksStorageService;
            _linksTableController = linksTableController;
            _linksSelectionController = linksSelectionController;
            _controlsStateManagementController = controlsStateManagementController;
            _subscribers = new List<IInfoObserverController>();
            _bondInfoItems = new List<BondInfo?>();

            _linksManagementView.LinkAdding += (sender, args) => HandleLinkAdding();
            _linksManagementView.LinksRemoving += (sender, args) => HandleLinksRemoving();
            _linksManagementView.LinksAnalyzing += (sender, args) => HandleLinksAnalyzing();
            _linksManagementView.LinksRestoring += (sender, args) => HandleLinksRestoring();
            _linksManagementView.LinksSaving += (sender, args) => HandleLinksSaving();

            _linksSelectionController.SelectionChanged += HandleSelectionChanged;
        }

        #region IObservableController Members

        public void Subcribe(IInfoObserverController subscriber) => _subscribers.Add(subscriber);

        public void Unsubscribe(IInfoObserverController subscriber) => _subscribers.Remove(subscriber);

        #endregion IObservableController Members

        #region Private Members

        private void ClearBondInfo()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.ClearInfo();
            }
        }

        private void UpdateBondInfo()
        {
            var linkRowItem = _linksSelectionController.GetSelectedBondLinkRowItem();
            if (linkRowItem is null)
            {
                return;
            }

            var bondInfo = _bondInfoItems?.FirstOrDefault(item => item!.Link == linkRowItem.Link);
            if (bondInfo is null)
            {
                return;
            }

            _subscribers.AsParallel().ForAll(subscriber => subscriber.FillInfo(bondInfo));
        }

        private void HandleLinkAdding()
        {
            _linksTableController.AddLinkRow(_linksManagementView.LinkText);
            _linksManagementView.LinkText = null;
        }

        private void HandleLinksRemoving()
        {
            foreach (var link in _linksTableController.RemoveSelectedLinkRows())
            {
                if (string.IsNullOrWhiteSpace(link))
                {
                    continue;
                }

                var bondInfo = _bondInfoItems?.FirstOrDefault(item => item!.Link == link);
                if (bondInfo is not null)
                {
                    _bondInfoItems?.Remove(bondInfo);
                }
            }

            if (_linksTableController.LinksCount == 0)
            {
                ClearBondInfo();
            }
        }

        private void HandleLinksAnalyzing()
        {
            ClearBondInfo();

            _controlsStateManagementController.SetAnalyzeProcessingControlsState(false);

            var links = _linksTableController.GetLinks();
            if (links is null)
            {
                MessageBox.Show("Отсутствуют ссылки на облигации.", "Анализ информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _bondInfoItems = new List<BondInfo?>();
                _controlsStateManagementController.SetAnalyzeProcessingControlsState(true);

                return;
            }

            _bondInfoItems = links
                .AsParallel()
                .Where(link => !string.IsNullOrWhiteSpace(link))
                .Select(link => _bondParser.GetBondInfoAsync(link).Result)
                .Where(bondInfo => bondInfo is not null)
                .ToList() ?? new List<BondInfo?>();
            if (_bondInfoItems.Count == 0)
            {
                MessageBox.Show("Информация по добавленным ссылкам не найдена.", "Анализ информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _controlsStateManagementController.SetAnalyzeProcessingControlsState(true);

                return;
            }

            _linksSelectionController.SelectionChanged -= HandleSelectionChanged;

            foreach (var bondInfo in _bondInfoItems)
            {
                _yieldCalculatorService.UpdateYieldInfo(bondInfo);
                _linksTableController.UpdateLinkRowItem(bondInfo);
            }

            UpdateBondInfo();

            _controlsStateManagementController.SetAnalyzeProcessingControlsState(true);
            _linksSelectionController.SelectionChanged += HandleSelectionChanged;
        }

        private void HandleLinksRestoring()
        {
            if (!_linksStorageService.IsExists)
            {
                MessageBox.Show("Хранилище не найдено.", "Восстановление ссылок", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var links = _linksStorageService.GetLinks()?.ToList();
            if (links is null)
            {
                MessageBox.Show("В хранилище отсутствуют ссылки на облигации.", "Восстановление ссылок", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearBondInfo();
            _bondInfoItems.Clear();
            _linksTableController.ClearTable();

            foreach (var link in links)
            {
                _linksTableController.AddLinkRow(link);
            }
        }

        private void HandleLinksSaving()
        {
            var links = _linksTableController
                .GetLinks()?
                .Where(link => !string.IsNullOrWhiteSpace(link))
                .ToList();
            if (links is null || links.Count == 0)
            {
                MessageBox.Show("Отсутствуют ссылки на облигации.", "Сохранение ссылок", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _linksStorageService.Save(links);
            MessageBox.Show("Ссылки успешно сохранены.", "Сохранение ссылок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HandleSelectionChanged(object? sender, EventArgs args)
        {
            _controlsStateManagementController.BondInfoEnabled = false;
            UpdateBondInfo();
            _controlsStateManagementController.BondInfoEnabled = true;
        }

        #endregion Private Members
    }
}
