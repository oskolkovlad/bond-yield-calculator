namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.GUI.Interfaces.Forms;
    using BondYieldCalculator.Parser;

    internal class LinkController
    {
        private readonly ILinkForm _form;
        private readonly IBondParser _bondParser;

        public LinkController(ILinkForm form, IBondParser bondParser)
        {
            _form = form;
            _bondParser = bondParser;

            _form.AnalyzeBond += (sender, args) => HandleAnalyzeBond();
        }

        private void HandleAnalyzeBond()
        {
            if (string.IsNullOrWhiteSpace(_form.LinkText))
            {
                return;
            }

            var bondInfo = _bondParser.GetBondInfoAsync(_form.LinkText).Result;
        }
    }
}
