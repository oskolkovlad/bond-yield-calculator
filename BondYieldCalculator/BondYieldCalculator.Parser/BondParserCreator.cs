namespace BondYieldCalculator.Parser
{
    public class BondParserCreator
    {
        public IBondParser CreateSmartLabBondParser() => new SmartLabBondParser();
    }
}