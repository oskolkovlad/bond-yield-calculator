namespace BondYieldCalculator.GUI.ViewControls.Views
{
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal partial class YieldInfoView : UserControl, IYieldInfoView, IYieldInfoControlsStateManagementView
    {
        public YieldInfoView()
        {
            InitializeComponent();
        }

        #region IYieldInfoView Members

        public string? YieldText
        {
            get { return yieldTextBox.Text; }
            set { this.InvokeIfRequired(() => yieldTextBox.Text = value); }
        }

        public string? CapitalGainsPercentText
        {
            get { return capitalGainsPercentTextBox.Text; }
            set { this.InvokeIfRequired(() => capitalGainsPercentTextBox.Text = value); }
        }

        public string? RealCouponIncomeText
        {
            get { return realCouponIncomeTextBox.Text; }
            set { this.InvokeIfRequired(() => realCouponIncomeTextBox.Text = value); }
        }

        public string? RealCouponIncomePercentText
        {
            get { return realCouponIncomePercentTextBox.Text; }
            set { this.InvokeIfRequired(() => realCouponIncomePercentTextBox.Text = value); }
        }

        public string? RealYieldPercentText
        {
            get { return realYieldPercentTextBox.Text; }
            set { this.InvokeIfRequired(() => realYieldPercentTextBox.Text = value); }
        }

        #endregion IYieldInfoView Members

        #region IYieldInfoControlsStateManagementView Members

        public bool GroupBoxEnabled
        {
            get { return yieldInfoGroupBox.Enabled; }
            set { this.InvokeIfRequired(() => yieldInfoGroupBox.Enabled = value); }
        }

        #endregion IYieldInfoControlsStateManagementView Members
    }
}
