namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    using BondYieldCalculator.Entities.Dto;

    internal interface IInfoObserverController : IController
    {
        void ClearInfo();

        void FillInfo(BondInfo? bondInfo);
    }
}
