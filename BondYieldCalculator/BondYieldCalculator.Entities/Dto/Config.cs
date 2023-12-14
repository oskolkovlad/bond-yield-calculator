namespace BondYieldCalculator.Entities.Dto
{
    public class Config
    {
        /// <summary>
        /// Налоговая ставка.
        /// </summary>
        public decimal TaxClearanceRatioPercent { get; set; }

        /// <summary>
        /// Комиссия брокера.
        /// </summary>
        public decimal BrokerCommissionPercent { get; set; }
    }
}
