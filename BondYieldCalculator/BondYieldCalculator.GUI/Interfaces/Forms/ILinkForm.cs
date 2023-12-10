namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface ILinkForm : IForm
    {
        bool BondPanelEnabled { get; set; }

        string? LinkText { get; set; }

        event EventHandler LinkAdding;

        event EventHandler LinksRemoving;

        event EventHandler LinksAnalyzing;

        event EventHandler LinksOpening;

        event EventHandler LinksSaving;
    }
}
