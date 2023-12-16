namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    internal interface IObservableController : IController
    {
        void Subcribe(IInfoObserverController controller);

        void Unsubscribe(IInfoObserverController controller);
    }
}
