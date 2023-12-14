namespace BondYieldCalculator.Parser
{
    using BondYieldCalculator.Entities.Dto;

    public interface IBondParser
    {
        Task<BondInfo?> GetBondInfoAsync(string? url);
    }
}
