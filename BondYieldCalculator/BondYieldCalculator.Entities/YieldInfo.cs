namespace BondYieldCalculator.Entities
{
    /// <summary>
    /// Информация о доходности облигации.
    /// </summary>
    public class YieldInfo
    {
        /// <summary>
        /// Прибыль в денежной единице.
        /// </summary>
        public decimal Yield { get; set; }

        /// <summary>
        /// Прирост вложенного капитала в процентах.
        /// </summary>
        public decimal CapitalGainsPercent { get; set; }

        /// <summary>
        /// Реальный купонный доход за год в денежной единице.
        /// </summary>
        public decimal RealCouponIncome { get; set; }

        /// <summary>
        /// Реальный купонный доход за год в процентах.
        /// </summary>
        public decimal RealCouponIncomePercent { get; set; }

        /// <summary>
        /// Реальная доходность за год в процентах.
        /// </summary>
        public decimal RealYieldPercent { get; set; }
    }
}
