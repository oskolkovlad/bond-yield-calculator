namespace BondYieldCalculator.GUI.Interfaces.ViewControls.Views
{
    internal interface ILinksControlsStateManagementView : IView
    {
        bool LintTextBoxEnabled { get; set; }

        bool AddLinkButtonEnabled { get; set; }

        bool RemoveLinksButtonEnabled { get; set; }

        bool AnalyzeButtonEnabled { get; set; }

        bool RestoreLinksButtonEnabled { get; set; }

        bool SaveLinksButtonEnabled { get; set; }
    }
}
