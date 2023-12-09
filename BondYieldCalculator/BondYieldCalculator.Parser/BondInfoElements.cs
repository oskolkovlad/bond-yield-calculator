namespace BondYieldCalculator.Parser
{
    internal static class BondInfoElements
    {
        public const string CommonBondInfoXpath = ".//div[@class='quotes-body__block']/section[@class='quotes-info-list']/article[1]";

        public const string CouponInfoXpath = ".//div[@class='quotes-body__block']/section[@class='quotes-info-list']/article[2]";

        public const string NominalPriceXpath = ".//div/div[1]/div[2]";

        public const string CurrentPriceXpath = ".//div/div[11]/div[2]";

        public const string MaturityXpath = ".//div/div[6]/div[2]";

        public const string AccumulatedCouponIncomeXpath = ".//div/div[8]/div[2]";

        public const string CouponXpath = ".//div/div[2]/div[2]";

        public const string CouponsQuantityXpath = ".//div/div[4]/div[2]";

        public const string CouponPaymentsRowsXpath = "/html/body/div[1]/main/div[2]/div[3]/div[2]/table/tbody/tr";
    }
}
