namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;

    internal class CouponInfoController : IInfoObserverController
    {
        private readonly ICouponInfoForm _form;

        public CouponInfoController(ICouponInfoForm form)
        {
            _form = form;
        }

        public void FillInfo(BondInfo bondInfo)
        {
            throw new NotImplementedException();
        }
    }
}
