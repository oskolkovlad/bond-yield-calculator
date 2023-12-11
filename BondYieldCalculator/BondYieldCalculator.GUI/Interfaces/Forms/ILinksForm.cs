namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface ILinksForm : IForm
    {
        string? LinkText { get; set; }

        event EventHandler LinkAdding;

        event EventHandler LinksRemoving;

        event EventHandler LinksAnalyzing;

        event EventHandler LinksOpening;

        event EventHandler LinksSaving;
    }
}
