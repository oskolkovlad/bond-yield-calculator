namespace BondYieldCalculator.Parser
{
    using BondYieldCalculator.Entities;

    public interface IBondParser
    {
        Task<BondInfo?> GetBondInfoAsync(string? url);
    }
}
