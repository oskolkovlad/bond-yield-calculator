namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;
    using BondYieldCalculator.Parser;

    internal class LinkController : IObservableController
    {
        private readonly ILinkForm _form;
        private readonly IBondParser _bondParser;
        private readonly IList<IInfoObserverController> _subscribers;

        public LinkController(ILinkForm form, IBondParser bondParser)
        {
            _form = form;
            _bondParser = bondParser;
            _subscribers = new List<IInfoObserverController>();

            _form.AnalyzeBond += (sender, args) => HandleAnalyzeBond();
        }

        #region IObservableController Members

        public void Subcribe(IInfoObserverController subscriber) => _subscribers.Add(subscriber);

        public void Unsubscribe(IInfoObserverController subscriber) => _subscribers.Remove(subscriber);

        #endregion IObservableController Members

        #region Private Members

        private void HandleAnalyzeBond()
        {
            _form.BondPanelEnabled = false;

            if (string.IsNullOrWhiteSpace(_form.LinkText))
            {
                return;
            }

            var bondInfo = _bondParser.GetBondInfoAsync(_form.LinkText).Result;
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
