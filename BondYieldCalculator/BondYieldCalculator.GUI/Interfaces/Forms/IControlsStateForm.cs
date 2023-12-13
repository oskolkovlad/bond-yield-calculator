namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface IControlsStateForm : IForm
    {
        public bool LintTextBoxEnabled { get; set; }

        public bool AddLinkButtonEnabled { get; set; }

        public bool RemoveLinksButtonEnabled { get; set; }

        public bool AnalyzeButtonEnabled { get; set; }

        public bool RestoreLinksButtonEnabled { get; set; }

        public bool SaveLinksButtonEnabled { get; set; }

        public bool BondPanelEnabled { get; set; }
    }
}
