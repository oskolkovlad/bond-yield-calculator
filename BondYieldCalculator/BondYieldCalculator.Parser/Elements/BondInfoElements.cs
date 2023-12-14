namespace BondYieldCalculator.Parser.Elements
{
    internal static class BondInfoElements
    {
        public const string BondTabsXpath = "/html/body/div[1]/main/div[1]/div[2]/div/div[1]/ul/li";

        public const string CommonBondInfoXpath = ".//div[@class='quotes-body__block']/section[@class='quotes-info-list']/article[1]";

        public const string CouponInfoXpath = ".//div[@class='quotes-body__block']/section[@class='quotes-info-list']/article[2]";

        public const string BondNameInfoXpath = ".//div[@class='quotes-body__block']/section[@class='quotes-info-list']/article[4]";

        public const string NameXpath = ".//div/div[1]/div[2]";

        public const string NominalPriceXpath = ".//div/div[11]/div[2]";

        public const string CurrentPriceXpath = ".//div/div[1]/div[2]";

        public const string MaturityXpath = ".//div/div[6]/div[2]";

        public const string CouponsQuantityXpath = "/html/body/div[1]/main/div[2]/div[3]/div[2]/table/tbody/tr";
    }
}
