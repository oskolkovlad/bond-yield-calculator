namespace BondYieldCalculator.Entities
{
    public class CouponInfo
    {
        public decimal AccumulatedCouponIncome { get; set; }

        public decimal Coupon { get; set; }

        public int CouponsQuantity { get; set; }

        public int QuantityOfPaymentsInYear { get; set; }
    }
}
