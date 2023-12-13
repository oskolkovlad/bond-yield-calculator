namespace BondYieldCalculator.GUI.ViewControls.Views
{
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal partial class CouponInfoView : UserControl, ICouponInfoView, ICouponInfoControlsStateManagementView
    {
        public CouponInfoView()
        {
            InitializeComponent();
        }

        #region ICouponInfoView Members

        public string? AccumulatedCouponIncomeText
        {
            get { return accumulatedCouponIncomeTextBox.Text; }
            set { this.InvokeIfRequired(() => accumulatedCouponIncomeTextBox.Text = value); }
        }

        public string? CouponText
        {
            get { return couponTextBox.Text; }
            set { this.InvokeIfRequired(() => couponTextBox.Text = value); }
        }

        public string? CouponsQuantityText
        {
            get { return couponsQuantityTextBox.Text; }
            set { this.InvokeIfRequired(() => couponsQuantityTextBox.Text = value); }
        }

        public string? QuantityOfPaymentsInYearText
        {
            get { return quantityOfPaymentsInYearTextBox.Text; }
            set { this.InvokeIfRequired(() => quantityOfPaymentsInYearTextBox.Text = value); }
        }

        #endregion ICouponInfoView Members

        #region ICouponInfoControlsStateManagementView Members

        public bool GroupBoxEnabled
        {
            get { return couponInfoGroupBox.Enabled; }
            set { this.InvokeIfRequired(() => couponInfoGroupBox.Enabled = value); }
        }

        #endregion ICouponInfoControlsStateManagementView Members
    }
}
