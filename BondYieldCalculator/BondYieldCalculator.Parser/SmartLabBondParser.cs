namespace BondYieldCalculator.Parser
{
    using System.Collections.Generic;
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.Entities.Dto;
    using BondYieldCalculator.Parser.Elements;
    using BondYieldCalculator.Services;
    using HtmlAgilityPack;

    internal class SmartLabBondParser : HtmlBondParser, IBondParser
    {
        private static readonly IReadOnlyDictionary<BondType, IReadOnlyDictionary<string, string>> _xPathsByBondType = new Dictionary<BondType, IReadOnlyDictionary<string, string>>
        {
            {
                BondType.WithoutRating,
                new Dictionary<string, string>(3)
                {
                    { nameof(CouponInfo.AccumulatedCouponIncome), BondInfoWithoutRatingElements.AccumulatedCouponIncomeXpath },
                    { nameof(CouponInfo.Coupon), BondInfoWithoutRatingElements.CouponXpath },
                    { nameof(CouponInfo.QuantityOfPaymentsInYear), BondInfoWithoutRatingElements.QuantityOfPaymentsInYearXpath },
                }
            },
            {
                BondType.WithRating,
                new Dictionary<string, string>(3)
                {
                    { nameof(CouponInfo.AccumulatedCouponIncome), BondInfoWithRatingElements.AccumulatedCouponIncomeXpath },
                    { nameof(CouponInfo.Coupon), BondInfoWithRatingElements.CouponXpath },
                    { nameof(CouponInfo.QuantityOfPaymentsInYear), BondInfoWithRatingElements.QuantityOfPaymentsInYearXpath },
                }
            }
        };

        public SmartLabBondParser(ILogService logService) : base(logService) { }

        #region IBondParser Members

        public Task<BondInfo?> GetBondInfoAsync(string? url) => ParseAsync(url);

        #endregion IBondParser Members

        #region Protected Members

        protected override BondInfo? GetBondInfo(HtmlDocument document) =>
            new BondInfo { CommonInfo = GetCommonInfo(document), CouponInfo = GetCouponInfo(GetBondType(document), document) };

        #endregion Protected Members

        #region Private Members

        private BondType GetBondType(HtmlDocument document)
        {
            var node = document.DocumentNode
                .SelectSingleNode(BondInfoElements.CouponInfoXpath)?
                .SelectSingleNode(BondInfoWithRatingElements.RaitingLabelXpath);
            if (node is null)
            {
                throw new ApplicationException("Необходимый элемент не найден.");
            }

            return node.InnerText?.TrimInnerText() == "Кредитный рейтинг" ? BondType.WithRating : BondType.WithoutRating;
        }

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

        private CouponInfo? GetCouponInfo(BondType bondType, HtmlDocument document)
        {
            var node = document.DocumentNode.SelectSingleNode(BondInfoElements.CouponInfoXpath);

            var xPath = _xPathsByBondType[bondType][nameof(CouponInfo.AccumulatedCouponIncome)];
            var accumulatedCouponIncome = node?.SelectSingleNode(xPath)?.InnerText?.TrimInnerTextWithRemoveWord("руб");
            if (accumulatedCouponIncome is null)
            {
                throw new ApplicationException("Накопительный купонный доход облигации не найден.");
            }

            xPath = _xPathsByBondType[bondType][nameof(CouponInfo.Coupon)];
            var coupon = node?.SelectSingleNode(xPath)?.InnerText?.TrimInnerTextWithRemoveWord("руб");
            if (coupon is null)
            {
                throw new ApplicationException("Величина купона не найдена.");
            }

            var couponsQuantity = node?.SelectNodes(BondInfoElements.CouponsQuantityXpath)?.Count;
            if (couponsQuantity is null)
            {
                throw new ApplicationException("Количество купонов не найдено.");
            }

            xPath = _xPathsByBondType[bondType][nameof(CouponInfo.QuantityOfPaymentsInYear)];
            var quantityOfPaymentsInYear = node?.SelectSingleNode(xPath)?.InnerText?.TrimInnerText();
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
