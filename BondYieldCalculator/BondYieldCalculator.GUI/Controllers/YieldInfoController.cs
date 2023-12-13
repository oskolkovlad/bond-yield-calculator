namespace BondYieldCalculator.GUI.Controllers
{
    using System.Globalization;
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal class YieldInfoController : IInfoObserverController
    {
        private readonly IYieldInfoView _yieldInfoView;

        public YieldInfoController(IYieldInfoView yieldInfoView)
        {
            _yieldInfoView = yieldInfoView;
        }

        public void ClearInfo()
        {
            _yieldInfoView.YieldText = null;
            _yieldInfoView.CapitalGainsPercentText = null;
            _yieldInfoView.RealCouponIncomeText = null;
            _yieldInfoView.RealCouponIncomePercentText = null;
            _yieldInfoView.RealYieldPercentText = null;
        }

        public void FillInfo(BondInfo? bondInfo)
        {
            if (bondInfo is null)
            {
                return;
            }

            _yieldInfoView.YieldText = bondInfo.YieldInfo?.Yield.ToString(CultureInfo.InvariantCulture);
            _yieldInfoView.CapitalGainsPercentText = bondInfo.YieldInfo?.CapitalGainsPercent.ToString(CultureInfo.InvariantCulture);
            _yieldInfoView.RealCouponIncomeText = bondInfo.YieldInfo?.RealCouponIncome.ToString(CultureInfo.InvariantCulture);
            _yieldInfoView.RealCouponIncomePercentText = bondInfo.YieldInfo?.RealCouponIncomePercent.ToString(CultureInfo.InvariantCulture);
            _yieldInfoView.RealYieldPercentText = bondInfo.YieldInfo?.RealYieldPercent.ToString(CultureInfo.InvariantCulture);
        }
    }
}
