namespace BondYieldCalculator.GUI.Interfaces.ViewControls.Views
{
    internal interface ILinksManagementView : IView
    {
        string? LinkText { get; set; }

        event EventHandler LinkAdding;

        event EventHandler LinksRemoving;

        event EventHandler LinksAnalyzing;

        event EventHandler LinksRestoring;

        event EventHandler LinksSaving;
    }
}
