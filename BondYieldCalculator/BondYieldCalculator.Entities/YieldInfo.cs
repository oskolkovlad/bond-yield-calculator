namespace BondYieldCalculator.Entities
{
    public class YieldInfo
    {
        public decimal Yield { get; set; }

        public decimal RealCouponIncome { get; set; }

        public double CapitalGainsPercent { get; set; }

        public double RealCouponIncomePercent { get; set; }

        public double RealYieldPercent { get; set; }
    }
}
