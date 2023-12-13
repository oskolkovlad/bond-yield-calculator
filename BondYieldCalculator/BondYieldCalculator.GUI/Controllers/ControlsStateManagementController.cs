namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal class ControlsStateManagementController : IControlsStateManagementController
    {
        private readonly ILinksControlsStateManagementView _linksControlsStateManagementView;
        private readonly ICommonInfoControlsStateManagementView _commonInfoControlsStateManagementView;
        private readonly ICouponInfoControlsStateManagementView _couponInfoControlsStateManagementView;
        private readonly IYieldInfoControlsStateManagementView _yieldInfoControlsStateManagementView;

        public ControlsStateManagementController(
            ILinksControlsStateManagementView linksControlsStateManagementView,
            ICommonInfoControlsStateManagementView commonInfoControlsStateManagementView,
            ICouponInfoControlsStateManagementView couponInfoControlsStateManagementView,
            IYieldInfoControlsStateManagementView yieldInfoControlsStateManagementView)
        {
            _linksControlsStateManagementView = linksControlsStateManagementView;
            _commonInfoControlsStateManagementView = commonInfoControlsStateManagementView;
            _couponInfoControlsStateManagementView = couponInfoControlsStateManagementView;
            _yieldInfoControlsStateManagementView = yieldInfoControlsStateManagementView;
        }

        public bool LintTextBoxEnabled
        {
            get { return _linksControlsStateManagementView.LintTextBoxEnabled; }
            set { _linksControlsStateManagementView.LintTextBoxEnabled = value; }
        }

        public bool AddLinkButtonEnabled
        {
            get { return _linksControlsStateManagementView.AddLinkButtonEnabled; }
            set { _linksControlsStateManagementView.AddLinkButtonEnabled = value; }
        }

        public bool RemoveLinksButtonEnabled
        {
            get { return _linksControlsStateManagementView.RemoveLinksButtonEnabled; }
            set { _linksControlsStateManagementView.RemoveLinksButtonEnabled = value; }
        }

        public bool AnalyzeButtonEnabled
        {
            get { return _linksControlsStateManagementView.AnalyzeButtonEnabled; }
            set { _linksControlsStateManagementView.AnalyzeButtonEnabled = value; }
        }

        public bool RestoreLinksButtonEnabled
        {
            get { return _linksControlsStateManagementView.RestoreLinksButtonEnabled; }
            set { _linksControlsStateManagementView.RestoreLinksButtonEnabled = value; }
        }

        public bool SaveLinksButtonEnabled
        {
            get { return _linksControlsStateManagementView.SaveLinksButtonEnabled; }
            set { _linksControlsStateManagementView.SaveLinksButtonEnabled = value; }
        }

        public bool BondPanelEnabled
        {
            get
            {
                return _commonInfoControlsStateManagementView.GroupBoxEnabled &&
                    _couponInfoControlsStateManagementView.GroupBoxEnabled &&
                    _yieldInfoControlsStateManagementView.GroupBoxEnabled;
            }
            set
            {
                _commonInfoControlsStateManagementView.GroupBoxEnabled = value;
                _couponInfoControlsStateManagementView.GroupBoxEnabled = value;
                _yieldInfoControlsStateManagementView.GroupBoxEnabled = value;
            }
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
