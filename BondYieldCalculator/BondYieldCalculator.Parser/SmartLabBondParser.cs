namespace BondYieldCalculator.Parser
{
    using System.Globalization;
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

            var nominalPrice = node?.SelectSingleNode(BondInfoElements.NominalPriceXpath)?.InnerText?.Trim('\n', '\t', '\r', '%');
            if (nominalPrice is null)
            {
                return null;
            }

            var currentPrice = node?.SelectSingleNode(BondInfoElements.CurrentPriceXpath)?.InnerText?.Trim('\n', '\t', '\r');
            if (currentPrice is null)
            {
                return null;
            }

            var maturity = node?.SelectSingleNode(BondInfoElements.MaturityXpath)?.InnerText?.Trim('\n', '\t', '\r');
            if (maturity is null)
            {
                return null;
            }

            return new CommonBondInfo
            {
                NominalPrice = decimal.Parse(nominalPrice, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture),
                CurrentPrice = decimal.Parse(currentPrice, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture) * 100,
                Maturity = decimal.Parse(maturity, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture)
            };
        }

        private CouponInfo? GetCouponInfo(HtmlDocument document)
        {
            var node = document.DocumentNode.SelectSingleNode(BondInfoElements.CouponInfoXpath);

            var accumulatedCouponIncome = node?.SelectSingleNode(BondInfoElements.AccumulatedCouponIncomeXpath)?.InnerText?.Replace("руб", "")?.Trim('\n', '\t', '\r', ' ');
            if (accumulatedCouponIncome is null)
            {
                return null;
            }

            var coupon = node?.SelectSingleNode(BondInfoElements.CouponXpath)?.InnerText?.Replace("руб", "")?.Trim('\n', '\t', '\r', ' ');
            if (coupon is null)
            {
                return null;
            }

            var couponsQuantity = node?.SelectSingleNode(BondInfoElements.CouponsQuantityXpath)?.InnerText?.Trim('\n', '\t', '\r');
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
                AccumulatedCouponIncome = decimal.Parse(accumulatedCouponIncome, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture),
                Coupon = decimal.Parse(coupon, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture),
                CouponsQuantity = (int)decimal.Parse(couponsQuantity, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture),
                QuantityOfPayments = quantityOfPayments.HasValue ? quantityOfPayments.Value : 0
            };
        }

        #endregion Private Members
    }
}
