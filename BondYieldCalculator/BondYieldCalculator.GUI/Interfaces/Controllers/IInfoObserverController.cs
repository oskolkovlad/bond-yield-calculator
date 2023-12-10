namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    using BondYieldCalculator.Entities;

    internal interface IInfoObserverController : IController
    {
        void ClearInfo();

        void FillInfo(BondInfo? bondInfo);
    }
}
