namespace BondYieldCalculator.Entities
{
    public class BondInfo
    {
        public string? Link { get; set; }

        public CommonBondInfo? CommonInfo { get; set; }

        public CouponInfo? CouponInfo { get; set; }

        public YieldInfo? YieldInfo { get; set; }
    }
}