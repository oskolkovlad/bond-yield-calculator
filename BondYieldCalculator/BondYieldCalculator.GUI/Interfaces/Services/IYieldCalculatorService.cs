namespace BondYieldCalculator.GUI.Interfaces.Services
{
    using BondYieldCalculator.Entities;

    internal interface IYieldCalculatorService
    {
        void UpdateYieldInfo(BondInfo? bondInfo);
    }
}
