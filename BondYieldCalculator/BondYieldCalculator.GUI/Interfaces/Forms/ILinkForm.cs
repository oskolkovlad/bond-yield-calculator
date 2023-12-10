namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface ILinkForm : IForm
    {
        bool BondPanelEnabled { get; set; }

        string LinkText { get; set; }

        event EventHandler AnalyzeBond;
    }
}
