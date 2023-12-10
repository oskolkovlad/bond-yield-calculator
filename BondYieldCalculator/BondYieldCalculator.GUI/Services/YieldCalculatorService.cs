﻿namespace BondYieldCalculator.GUI.Services
{
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Services;

    internal class YieldCalculatorService : IYieldCalculatorService
    {
        private const decimal TaxClearanceRatio = 0.87M; // TODO: get from config.
        private const decimal BrokerCommission = 0.0006M; // TODO: get from config.

        public void UpdateYieldInfo(BondInfo bondInfo)
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

        private static decimal TruncateDecimalValue(decimal value) => Math.Truncate(value * 100) / 100;
    }
}