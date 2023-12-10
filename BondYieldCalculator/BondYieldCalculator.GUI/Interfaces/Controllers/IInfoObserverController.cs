using BondYieldCalculator.Entities;

namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    internal interface IInfoObserverController : IController
    {
        void FillInfo(BondInfo bondInfo);
    }
}
