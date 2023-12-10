namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;

    internal class YieldInfoController : IInfoObserverController
    {
        private readonly IYieldInfoForm _form;

        public YieldInfoController(IYieldInfoForm form)
        {
            _form = form;
        }

        public void FillInfo(BondInfo bondInfo)
        {
            throw new NotImplementedException();
        }
    }
}
