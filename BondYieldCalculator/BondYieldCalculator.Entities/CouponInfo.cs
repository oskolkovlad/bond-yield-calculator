namespace BondYieldCalculator.Entities
{
    /// <summary>
    /// Информация о купонах облигации.
    /// </summary>
    public class CouponInfo
    {
        /// <summary>
        /// Накопительный купонный доход.
        /// </summary>
        public decimal AccumulatedCouponIncome { get; set; }

        /// <summary>
        /// Величина купона.
        /// </summary>
        public decimal Coupon { get; set; }

        /// <summary>
        /// Количество купонов.
        /// </summary>
        public int CouponsQuantity { get; set; }

        /// <summary>
        /// Количество выплат купонов в год.
        /// </summary>
        public int QuantityOfPaymentsInYear { get; set; }
    }
}
