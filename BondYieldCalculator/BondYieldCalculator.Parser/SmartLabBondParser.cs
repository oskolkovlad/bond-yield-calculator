namespace BondYieldCalculator.Parser
{
    using BondYieldCalculator.Entities;
    using HtmlAgilityPack;

    internal class SmartLabBondParser : HtmlBondParser, IBondParser
    {
        #region IBondParser Members

        public Task<BondInfo?> GetBondInfoAsync(string url) => ParseAsync(url);

        #endregion IBondParser Members

        #region Protected Members

        protected override BondInfo? GetBondInfo(HtmlDocument document) => new BondInfo { CommonInfo = GetCommonInfo(document), CouponInfo = GetCouponInfo(document) };

        #endregion Protected Members

        #region Private Members

        private CommonBondInfo? GetCommonInfo(HtmlDocument document)
        {
            var node = document.DocumentNode.SelectSingleNode(BondInfoElements.CommonBondInfoXpath);

            var nominalPrice = node?.SelectSingleNode(BondInfoElements.NominalPriceXpath)?.InnerText?.TrimInnerText();
            if (nominalPrice is null)
            {
                return null;
            }

            var currentPricePercent = node?.SelectSingleNode(BondInfoElements.CurrentPriceXpath)?.InnerText?.TrimInnerTextWithPercent();
            if (currentPricePercent is null)
            {
                return null;
            }

            var maturity = node?.SelectSingleNode(BondInfoElements.MaturityXpath)?.InnerText?.TrimInnerText();
            if (maturity is null)
            {
                return null;
            }

            var result = new CommonBondInfo { NominalPrice = nominalPrice.ParseInnerText(), Maturity = maturity.ParseInnerText() };
            result.CurrentPrice = currentPricePercent.ParseInnerText() * 1000 / 100;

            return result;
        }

        private CouponInfo? GetCouponInfo(HtmlDocument document)
        {
            var node = document.DocumentNode.SelectSingleNode(BondInfoElements.CouponInfoXpath);

            var accumulatedCouponIncome = node?.SelectSingleNode(BondInfoElements.AccumulatedCouponIncomeXpath)?.InnerText?.TrimInnerTextWithRemoveWord("руб");
            if (accumulatedCouponIncome is null)
            {
                return null;
            }

            var coupon = node?.SelectSingleNode(BondInfoElements.CouponXpath)?.InnerText?.TrimInnerTextWithRemoveWord("руб");
            if (coupon is null)
            {
                return null;
            }

            var couponsQuantity = node?.SelectSingleNode(BondInfoElements.CouponsQuantityXpath)?.InnerText?.TrimInnerText();
            if (couponsQuantity is null)
            {
                return null;
            }

            var quantityOfPayments = node?.SelectNodes(BondInfoElements.CouponPaymentsRowsXpath)?.Count;
            if (quantityOfPayments is null)
            {
                return null;
            }

            return new CouponInfo
            {
                AccumulatedCouponIncome = accumulatedCouponIncome.ParseInnerText(),
                Coupon = coupon.ParseInnerText(),
                CouponsQuantity = (int)couponsQuantity.ParseInnerText(),
                QuantityOfPayments = quantityOfPayments.HasValue ? quantityOfPayments.Value : 0
            };
        }

        #endregion Private Members
    }
}
