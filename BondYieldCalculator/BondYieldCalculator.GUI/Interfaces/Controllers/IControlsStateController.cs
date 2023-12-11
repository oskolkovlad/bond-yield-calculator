namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    internal interface IControlsStateController : IController
    {
        public bool BondPanelEnabled { get; set; }

        void SetSensitiveToRowsCountControlsEnabledState(bool value);
    }
}
