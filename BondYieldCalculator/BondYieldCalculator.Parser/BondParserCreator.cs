namespace BondYieldCalculator.Parser
{
    using BondYieldCalculator.Services;

    public class BondParserCreator
    {
        public IBondParser CreateSmartLabBondParser(ILogService logService) => new SmartLabBondParser(logService);
    }
}