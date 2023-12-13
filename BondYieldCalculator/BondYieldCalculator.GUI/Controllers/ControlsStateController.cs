namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;

    internal class ControlsStateController : IControlsStateController
    {
        private readonly IControlsStateForm _form;

        public ControlsStateController(IControlsStateForm form)
        {
            _form = form;
        }

        public bool LintTextBoxEnabled
        {
            get { return _form.LintTextBoxEnabled; }
            set { _form.LintTextBoxEnabled = value; }
        }

        public bool AddLinkButtonEnabled
        {
            get { return _form.AddLinkButtonEnabled; }
            set { _form.AddLinkButtonEnabled = value; }
        }

        public bool RemoveLinksButtonEnabled
        {
            get { return _form.RemoveLinksButtonEnabled; }
            set { _form.RemoveLinksButtonEnabled = value; }
        }

        public bool AnalyzeButtonEnabled
        {
            get { return _form.AnalyzeButtonEnabled; }
            set { _form.AnalyzeButtonEnabled = value; }
        }

        public bool RestoreLinksButtonEnabled
        {
            get { return _form.RestoreLinksButtonEnabled; }
            set { _form.RestoreLinksButtonEnabled = value; }
        }

        public bool SaveLinksButtonEnabled
        {
            get { return _form.SaveLinksButtonEnabled; }
            set { _form.SaveLinksButtonEnabled = value; }
        }

        public bool BondPanelEnabled
        {
            get { return _form.BondPanelEnabled; }
            set { _form.BondPanelEnabled = value; }
        }

        public void SetDependenceFromAnalyzeProcessingControlsState(bool value)
        {
            LintTextBoxEnabled = value;
            AddLinkButtonEnabled = value;
            RemoveLinksButtonEnabled = value;
            AnalyzeButtonEnabled = value;
            RestoreLinksButtonEnabled = value;
            SaveLinksButtonEnabled = value;
            BondPanelEnabled = value;
        }

        public void SetDependenceFromRowsCountControlsState(bool value)
        {
            RemoveLinksButtonEnabled = value;
            AnalyzeButtonEnabled = value;
            SaveLinksButtonEnabled = value;
            BondPanelEnabled = value;
        }
    }
}
