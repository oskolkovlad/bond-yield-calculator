namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface IControlsStateForm : IForm
    {
        bool BondPanelEnabled { get; set; }

        bool RemoveButtonEnabled { get; set; }

        bool AnalyzeButtonEnabled { get; set; }

        bool SaveLinksButtonEnabled { get; set; }
    }
}
