namespace BondYieldCalculator.Services
{
    using BondYieldCalculator.Entities.Dto;

    public interface IYieldCalculatorService : IService
    {
        void UpdateYieldInfo(BondInfo? bondInfo);
    }
}
