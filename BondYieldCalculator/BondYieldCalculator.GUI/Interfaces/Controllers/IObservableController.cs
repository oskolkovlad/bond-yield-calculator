namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    internal interface IObservableController : IController
    {
        void Subcribe(IInfoObserverController subscriber);

        void Unsubscribe(IInfoObserverController subscriber);
    }
}
