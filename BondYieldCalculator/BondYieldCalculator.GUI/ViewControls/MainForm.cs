namespace BondYieldCalculator.GUI.ViewControls
{
    using BondYieldCalculator.GUI.Interfaces.ViewControls;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal partial class MainForm : Form, IMainForm, IControlsStateManagementForm, IShortcutsForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region IMainForm Members

        public ILinksTableView LinksTableView => linksTableView;

        public ILinksManagementView LinksManagementView => linksTableView;

        public ICommonInfoView CommonInfoView => commonInfoView;

        public ICouponInfoView CouponInfoView => couponInfoView;

        public IYieldInfoView YieldInfoView => yieldInfoView;

        #endregion IMainForm Members

        #region IControlsStateManagementForm Members

        public ILinksControlsStateManagementView LinksControlsStateManagementView => linksTableView;

        public ICommonInfoControlsStateManagementView CommonInfoControlsStateManagementView => commonInfoView;

        public ICouponInfoControlsStateManagementView CouponInfoControlsStateManagementView => couponInfoView;

        public IYieldInfoControlsStateManagementView YieldInfoControlsStateManagementView => yieldInfoView;

        #endregion IControlsStateManagementForm Members

        #region IShortcutsForm Members

        public ILinksShortcutsView LinksShortcutsView => linksTableView;

        public event PreviewKeyDownEventHandler FormKeyDown = delegate { };

        #endregion IShortcutsForm Members
    }
}
