namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;

    internal class ControlsStateController : IControlsStateController
    {
        private readonly IControlsStateForm _form;

        public ControlsStateController(IControlsStateForm form)
        {
            _form = form;
        }

        public bool BondPanelEnabled
        {
            get { return _form.BondPanelEnabled; }
            set { _form.BondPanelEnabled = value; }
        }

        public void SetSensitiveToRowsCountControlsEnabledState(bool value)
        {
            BondPanelEnabled = value;

            _form.RemoveButtonEnabled = value;
            _form.AnalyzeButtonEnabled = value;
            _form.SaveLinksButtonEnabled = value;
        }
    }
}
