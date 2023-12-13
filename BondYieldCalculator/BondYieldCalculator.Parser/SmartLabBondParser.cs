namespace BondYieldCalculator.Parser
{
    using BondYieldCalculator.Entities;
    using HtmlAgilityPack;

    internal class SmartLabBondParser : HtmlBondParser, IBondParser
    {
        #region IBondParser Members

        public Task<BondInfo?> GetBondInfoAsync(string? url) => ParseAsync(url);

        #endregion IBondParser Members

        #region Protected Members

        protected override BondInfo? GetBondInfo(HtmlDocument document) => new BondInfo { CommonInfo = GetCommonInfo(document), CouponInfo = GetCouponInfo(document) };

        #endregion Protected Members

        #region Private Members

        private CommonBondInfo? GetCommonInfo(HtmlDocument document)
        {
            var node = document.DocumentNode.SelectSingleNode(BondInfoElements.BondNameInfoXpath);

            var name = node?.SelectSingleNode(BondInfoElements.NameXpath)?.InnerText?.TrimInnerText();
            if (name is null)
            {
                throw new ApplicationException("Наименование облигации не найдено.");
            }

            node = document.DocumentNode.SelectSingleNode(BondInfoElements.CommonBondInfoXpath);

            var nominalPrice = node?.SelectSingleNode(BondInfoElements.NominalPriceXpath)?.InnerText?.TrimInnerText();
            if (nominalPrice is null)
            {
                throw new ApplicationException("Номинал облигации не найден.");
            }

            var currentPricePercent = node?.SelectSingleNode(BondInfoElements.CurrentPriceXpath)?.InnerText?.TrimInnerTextWithPercent();
            if (currentPricePercent is null)
            {
                throw new ApplicationException("Текущая стоимость облигации не найдена.");
            }

            var maturity = node?.SelectSingleNode(BondInfoElements.MaturityXpath)?.InnerText?.TrimInnerText();
            if (maturity is null)
            {
                throw new ApplicationException("Срок до погашения облигации не найден.");
            }

            var result = new CommonBondInfo { Name = name, NominalPrice = nominalPrice.ParseInnerText(), Maturity = maturity.ParseInnerText() };
            result.CurrentPrice = currentPricePercent.ParseInnerText() * 1000 / 100;

            return result;
        }

        private CouponInfo? GetCouponInfo(HtmlDocument document)
        {
            var node = document.DocumentNode.SelectSingleNode(BondInfoElements.CouponInfoXpath);

            var accumulatedCouponIncome = node?.SelectSingleNode(BondInfoElements.AccumulatedCouponIncomeXpath)?.InnerText?.TrimInnerTextWithRemoveWord("руб");
            if (accumulatedCouponIncome is null)
            {
                throw new ApplicationException("Накопительный купонный доход облигации не найден.");
            }

            var coupon = node?.SelectSingleNode(BondInfoElements.CouponXpath)?.InnerText?.TrimInnerTextWithRemoveWord("руб");
            if (coupon is null)
            {
                throw new ApplicationException("Величина купона не найдена.");
            }

            var couponsQuantity = node?.SelectNodes(BondInfoElements.CouponsQuantityXpath)?.Count;
            if (couponsQuantity is null)
            {
                throw new ApplicationException("Количество купонов не найдено.");
            }

            var quantityOfPaymentsInYear = node?.SelectSingleNode(BondInfoElements.QuantityOfPaymentsInYearXpath)?.InnerText?.TrimInnerText();
            if (quantityOfPaymentsInYear is null)
            {
                throw new ApplicationException("Количество выплат купонов в год не найдено.");
            }

            return new CouponInfo
            {
                AccumulatedCouponIncome = accumulatedCouponIncome.ParseInnerText(),
                Coupon = coupon.ParseInnerText(),
                CouponsQuantity = couponsQuantity.HasValue ? couponsQuantity.Value : 0,
                QuantityOfPaymentsInYear = (int)quantityOfPaymentsInYear.ParseInnerText()
            };
        }

        #endregion Private Members
    }
}
