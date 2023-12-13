namespace BondYieldCalculator.GUI.ViewControls.Views
{
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal partial class CommonInfoView : UserControl, ICommonInfoView, ICommonInfoControlsStateManagementView
    {
        public CommonInfoView()
        {
            InitializeComponent();
        }

        #region ICommonInfoView Members

        public string? NameText
        {
            get { return nameTextBox.Text; }
            set { this.InvokeIfRequired(() => nameTextBox.Text = value); }
        }

        public string? NominalPriceText
        {
            get { return nominalPriceTextBox.Text; }
            set { this.InvokeIfRequired(() => nominalPriceTextBox.Text = value); }
        }

        public string? CurrentPriceText
        {
            get { return currentPriceTextBox.Text; }
            set { this.InvokeIfRequired(() => currentPriceTextBox.Text = value); }
        }

        public string? MaturityText
        {
            get { return maturityTextBox.Text; }
            set { this.InvokeIfRequired(() => maturityTextBox.Text = value); }
        }

        #endregion ICommonInfoView Members

        #region ICommonInfoControlsStateManagementView Members

        public bool GroupBoxEnabled
        {
            get { return commonInfoGroupBox.Enabled; }
            set { this.InvokeIfRequired(() => commonInfoGroupBox.Enabled = value); }
        }

        #endregion ICommonInfoControlsStateManagementView Members
    }
}
