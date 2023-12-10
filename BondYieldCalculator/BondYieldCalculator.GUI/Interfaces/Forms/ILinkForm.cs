namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface ILinkForm
    {
        bool BondPanelEnabled { get; set; }

        string LinkText { get; set; }

        event EventHandler AnalyzeBond;
    }
}
