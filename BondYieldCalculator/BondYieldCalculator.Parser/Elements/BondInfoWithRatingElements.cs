namespace BondYieldCalculator.Parser.Elements
{
    internal static class BondInfoWithRatingElements
    {
        public const string RaitingLabelXpath = ".//div/div[1]/div[1]";

        public const string RaitingValueXpath = ".//div/div[1]/div[2]/div/div/div";

        public const string AccumulatedCouponIncomeXpath = ".//div/div[9]/div[2]";

        public const string CouponXpath = ".//div/div[3]/div[2]";

        public const string QuantityOfPaymentsInYearXpath = ".//div/div[5]/div[2]";
    }
}
