namespace BondYieldCalculator.GUI.ViewControls
{
    using BondYieldCalculator.GUI.Interfaces.ViewControls;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public ILinksTableView LinksTableView => linksTableView;

        public ILinksManagementView LinksManagementView => linksTableView;

        public ILinksControlsStateManagementView LinksControlsStateManagementView => linksTableView;

        public ICommonInfoView CommonInfoView => commonInfoView;

        public ICommonInfoControlsStateManagementView CommonInfoControlsStateManagementView => commonInfoView;

        public ICouponInfoView CouponInfoView => couponInfoView;

        public ICouponInfoControlsStateManagementView CouponInfoControlsStateManagementView => couponInfoView;

        public IYieldInfoView YieldInfoView => yieldInfoView;

        public IYieldInfoControlsStateManagementView YieldInfoControlsStateManagementView => yieldInfoView;
    }
}
