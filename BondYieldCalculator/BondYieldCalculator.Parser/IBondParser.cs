using BondYieldCalculator.Entities;

namespace BondYieldCalculator.Parser
{
    public interface IBondParser
    {
        BondInfo GetBondInfo(string url);
    }
}
