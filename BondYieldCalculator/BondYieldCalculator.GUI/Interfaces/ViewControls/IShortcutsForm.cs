namespace BondYieldCalculator.GUI.Interfaces.ViewControls
{
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal interface IShortcutsForm : IForm
    {
        ILinksShortcutsView LinksShortcutsView { get; }

        event KeyEventHandler KeyDown;
    }
}
