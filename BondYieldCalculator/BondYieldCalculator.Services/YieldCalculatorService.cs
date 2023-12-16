namespace BondYieldCalculator.Services
{
    using BondYieldCalculator.Entities.Dto;

    internal class YieldCalculatorService : IYieldCalculatorService
    {
        private readonly IConfigService _configService;

        public YieldCalculatorService(IConfigService configService)
        {
            _configService = configService;
        }

        public void UpdateYieldInfo(BondInfo? bondInfo)
        {
            if (bondInfo?.CommonInfo is null || bondInfo?.CouponInfo is null)
            {
                return;
            }

            if (bondInfo.YieldInfo is null)
            {
                bondInfo.YieldInfo = new YieldInfo();
            }

            var couponYield = bondInfo.CouponInfo.CouponsQuantity * bondInfo.CouponInfo.Coupon * TaxClearanceRatio - bondInfo.CouponInfo.AccumulatedCouponIncome;
            var differenceCost = bondInfo.CommonInfo.NominalPrice - bondInfo.CommonInfo.CurrentPrice;
            var brokerCommissionCost = differenceCost > 0 ? differenceCost * BrokerCommission : 0;
            bondInfo.YieldInfo.Yield = TruncateDecimalValue(couponYield + differenceCost - brokerCommissionCost);

            bondInfo.YieldInfo.CapitalGainsPercent = TruncateDecimalValue(bondInfo.YieldInfo.Yield * 100 / bondInfo.CommonInfo.CurrentPrice);
            bondInfo.YieldInfo.RealCouponIncome = TruncateDecimalValue(bondInfo.CouponInfo.Coupon * bondInfo.CouponInfo.QuantityOfPaymentsInYear * TaxClearanceRatio);
            bondInfo.YieldInfo.RealCouponIncomePercent = TruncateDecimalValue(bondInfo.YieldInfo.RealCouponIncome * 100 / bondInfo.CommonInfo.CurrentPrice);
            bondInfo.YieldInfo.RealYieldPercent = TruncateDecimalValue(bondInfo.YieldInfo.CapitalGainsPercent / bondInfo.CommonInfo.Maturity);
        }

        private decimal TaxClearanceRatio => (100 - _configService.Instance.TaxClearanceRatioPercent) / 100;

        private decimal BrokerCommission => _configService.Instance.BrokerCommissionPercent / 100;

        private static decimal TruncateDecimalValue(decimal value) => Math.Truncate(value * 100) / 100;
    }
}
