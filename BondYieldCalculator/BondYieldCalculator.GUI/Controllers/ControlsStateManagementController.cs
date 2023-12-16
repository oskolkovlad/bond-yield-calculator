namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.ViewControls;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal class ControlsStateManagementController : IControlsStateManagementController
    {
        private readonly IControlsStateManagementForm _controlsStateManagementForm;

        public ControlsStateManagementController(IControlsStateManagementForm controlsStateManagementForm)
        {
            _controlsStateManagementForm = controlsStateManagementForm;
        }

        public bool LintTextBoxEnabled
        {
            get { return LinksControlsStateManagementView.LintTextBoxEnabled; }
            set { LinksControlsStateManagementView.LintTextBoxEnabled = value; }
        }

        public bool AddLinkButtonEnabled
        {
            get { return LinksControlsStateManagementView.AddLinkButtonEnabled; }
            set { LinksControlsStateManagementView.AddLinkButtonEnabled = value; }
        }

        public bool RemoveLinksButtonEnabled
        {
            get { return LinksControlsStateManagementView.RemoveLinksButtonEnabled; }
            set { LinksControlsStateManagementView.RemoveLinksButtonEnabled = value; }
        }

        public bool AnalyzeButtonEnabled
        {
            get { return LinksControlsStateManagementView.AnalyzeButtonEnabled; }
            set { LinksControlsStateManagementView.AnalyzeButtonEnabled = value; }
        }

        public bool RestoreLinksButtonEnabled
        {
            get { return LinksControlsStateManagementView.RestoreLinksButtonEnabled; }
            set { LinksControlsStateManagementView.RestoreLinksButtonEnabled = value; }
        }

        public bool SaveLinksButtonEnabled
        {
            get { return LinksControlsStateManagementView.SaveLinksButtonEnabled; }
            set { LinksControlsStateManagementView.SaveLinksButtonEnabled = value; }
        }

        public bool BondInfoEnabled
        {
            get
            {
                return CommonInfoControlsStateManagementView.GroupBoxEnabled &&
                    CouponInfoControlsStateManagementView.GroupBoxEnabled &&
                    YieldInfoControlsStateManagementView.GroupBoxEnabled;
            }
            set
            {
                CommonInfoControlsStateManagementView.GroupBoxEnabled = value;
                CouponInfoControlsStateManagementView.GroupBoxEnabled = value;
                YieldInfoControlsStateManagementView.GroupBoxEnabled = value;
            }
        }

        public void SetAnalyzeProcessingControlsState(bool value)
        {
            LintTextBoxEnabled = value;
            AddLinkButtonEnabled = value;
            RemoveLinksButtonEnabled = value;
            AnalyzeButtonEnabled = value;
            RestoreLinksButtonEnabled = value;
            SaveLinksButtonEnabled = value;
            BondInfoEnabled = value;
        }

        public void SetRowsCountControlsState(bool value)
        {
            RemoveLinksButtonEnabled = value;
            AnalyzeButtonEnabled = value;
            SaveLinksButtonEnabled = value;
            BondInfoEnabled = value;
        }

        private ILinksControlsStateManagementView LinksControlsStateManagementView => _controlsStateManagementForm.LinksControlsStateManagementView;

        private ICommonInfoControlsStateManagementView CommonInfoControlsStateManagementView => _controlsStateManagementForm.CommonInfoControlsStateManagementView;

        private ICouponInfoControlsStateManagementView CouponInfoControlsStateManagementView => _controlsStateManagementForm.CouponInfoControlsStateManagementView;

        private IYieldInfoControlsStateManagementView YieldInfoControlsStateManagementView => _controlsStateManagementForm.YieldInfoControlsStateManagementView;
    }
}
