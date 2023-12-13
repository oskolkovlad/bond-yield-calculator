namespace BondYieldCalculator.Entities
{
    /// <summary>
    /// Объект строки таблицы ссылок.
    /// </summary>
    public class BondLinkRowItem
    {
        /// <summary>
        /// Наименование облигации.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Ссылка на облигацию на сайте Smart-Lab.
        /// </summary>
        public string? Link { get; set; }

        /// <summary>
        /// Срок до погашения облигации.
        /// </summary>
        public decimal? Maturity { get; set; }

        /// <summary>
        /// Реальная доходность облигации за год в процентах.
        /// </summary>
        public decimal? RealYieldPercent { get; set; }
    }
}
