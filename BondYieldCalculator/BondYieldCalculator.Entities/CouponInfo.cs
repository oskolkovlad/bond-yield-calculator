namespace BondYieldCalculator.Entities
{
    public class CouponInfo
    {
        public decimal AccumulatedCouponIncome { get; set; }

        public decimal Coupon { get; set; }

        public decimal RealCouponIncome { get; set; }

        public double RealCouponIncomePercent { get; set; }

        public int CouponsQuantity { get; set; }

        public int QuantityOfPayments { get; set; }
    }
}
