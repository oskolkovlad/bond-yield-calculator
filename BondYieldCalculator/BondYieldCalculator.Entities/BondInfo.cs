namespace BondYieldCalculator.Entities
{
    /// <summary>
    /// Информация об облигации.
    /// </summary>
    public class BondInfo
    {
        /// <summary>
        /// Ссылка на облигацию на сайте Smart-Lab.
        /// </summary>
        public string? Link { get; set; }

        /// <summary>
        /// Общая информация об облигации.
        /// </summary>
        public CommonBondInfo? CommonInfo { get; set; }

        /// <summary>
        /// Информация о купонах облигации.
        /// </summary>
        public CouponInfo? CouponInfo { get; set; }

        /// <summary>
        /// Информация о доходности облигации.
        /// </summary>
        public YieldInfo? YieldInfo { get; set; }
    }
}