namespace BondYieldCalculator.Entities
{
    public class CommonBondInfo
    {
        public string? Name { get; set; }

        public decimal NominalPrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public decimal Maturity { get; set; }
    }
}
