namespace BondYieldCalculator.GUI.Interfaces.Services
{
    using BondYieldCalculator.Entities.Dto;

    internal interface IYieldCalculatorService
    {
        void UpdateYieldInfo(BondInfo? bondInfo);
    }
}
