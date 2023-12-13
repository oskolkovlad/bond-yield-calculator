namespace BondYieldCalculator.Entities
{
    /// <summary>
    /// Общая информация об облигации.
    /// </summary>
    public class CommonBondInfo
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Номинал.
        /// </summary>
        public decimal NominalPrice { get; set; }

        /// <summary>
        /// Текущая стоимость.
        /// </summary>
        public decimal CurrentPrice { get; set; }

        /// <summary>
        /// Срок до погашения.
        /// </summary>
        public decimal Maturity { get; set; }
    }
}
