namespace BondYieldCalculator.Services
{
    using BondYieldCalculator.Entities.Dto;

    public interface IYieldCalculatorService
    {
        void UpdateYieldInfo(BondInfo? bondInfo);
    }
}
