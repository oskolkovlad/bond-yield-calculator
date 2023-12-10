namespace BondYieldCalculator.GUI.Controllers
{
    using System.Globalization;
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

        public void ClearInfo()
        {
            _form.YieldText = null;
            _form.CapitalGainsPercentText = null;
            _form.RealCouponIncomeText = null;
            _form.RealCouponIncomePercentText = null;
            _form.RealYieldPercentText = null;
        }

        public void FillInfo(BondInfo? bondInfo)
        {
            if (bondInfo is null)
            {
                return;
            }

            _form.YieldText = bondInfo.YieldInfo?.Yield.ToString(CultureInfo.InvariantCulture);
            _form.CapitalGainsPercentText = bondInfo.YieldInfo?.CapitalGainsPercent.ToString(CultureInfo.InvariantCulture);
            _form.RealCouponIncomeText = bondInfo.YieldInfo?.RealCouponIncome.ToString(CultureInfo.InvariantCulture);
            _form.RealCouponIncomePercentText = bondInfo.YieldInfo?.RealCouponIncomePercent.ToString(CultureInfo.InvariantCulture);
            _form.RealYieldPercentText = bondInfo.YieldInfo?.RealYieldPercent.ToString(CultureInfo.InvariantCulture);
        }
    }
}
