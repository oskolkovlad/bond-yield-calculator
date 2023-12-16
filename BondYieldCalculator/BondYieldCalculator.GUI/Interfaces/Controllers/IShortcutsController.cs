namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    internal interface IShortcutsController : IController
    {
        event EventHandler LinkAdding;

        event EventHandler LinksRemoving;

        event EventHandler LinksAnalyzing;

        event EventHandler LinksRestoring;

        event EventHandler LinksSaving;
    }
}
