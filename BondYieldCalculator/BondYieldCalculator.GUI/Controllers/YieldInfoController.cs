namespace BondYieldCalculator.GUI.Controllers
{
    using System.Globalization;
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;
    using BondYieldCalculator.GUI.Interfaces.Services;

    internal class YieldInfoController : IInfoObserverController
    {
        private readonly IYieldInfoForm _form;
        private readonly IYieldCalculatorService _yieldCalculatorService;

        public YieldInfoController(IYieldInfoForm form, IYieldCalculatorService yieldCalculatorService)
        {
            _form = form;
            _yieldCalculatorService = yieldCalculatorService;
        }

        public void FillInfo(BondInfo bondInfo)
        {
            if (bondInfo is null)
            {
                return;
            }

            _yieldCalculatorService.UpdateYieldInfo(bondInfo);

            _form.YieldText = bondInfo.YieldInfo?.Yield.ToString(CultureInfo.InvariantCulture);
            _form.CapitalGainsPercentText = bondInfo.YieldInfo?.CapitalGainsPercent.ToString(CultureInfo.InvariantCulture);
            _form.RealCouponIncomeText = bondInfo.YieldInfo?.RealCouponIncome.ToString(CultureInfo.InvariantCulture);
            _form.RealCouponIncomePercentText = bondInfo.YieldInfo?.RealCouponIncomePercent.ToString(CultureInfo.InvariantCulture);
            _form.RealYieldPercentText = bondInfo.YieldInfo?.RealYieldPercent.ToString(CultureInfo.InvariantCulture);
        }
    }
}
