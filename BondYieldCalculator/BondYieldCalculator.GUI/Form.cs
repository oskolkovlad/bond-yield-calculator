namespace BondYieldCalculator.GUI
{
    using BondYieldCalculator.GUI.Interfaces.Forms;

    public partial class Form : System.Windows.Forms.Form,
        ILinkForm,
        ICommonBondInfoForm,
        ICouponInfoForm,
        IYieldInfoForm
    {
        public Form()
        {
            InitializeComponent();

            BondPanelEnabled = false;
            analyzeButton.Click += (sender, args) => AnalyzeBond?.Invoke(this, EventArgs.Empty);
        }

        #region IForm

        public void InvokeIfRequired(Action action)
        {
            if (InvokeRequired)
            {
                BeginInvoke(action);
            }
            else
            {
                action();
            }
        }

        #endregion IForm

        #region ILinkForm Members

        public bool BondPanelEnabled
        {
            get { return bondTableLayoutPanel.Enabled; }
            set { InvokeIfRequired(() => bondTableLayoutPanel.Enabled = value); }
        }

        public string LinkText
        {
            get { return linkTextBox.Text; }
            set { InvokeIfRequired(() => linkTextBox.Text = value); }
        }

        public event EventHandler AnalyzeBond;

        #endregion ILinkForm Members

        #region ICommonBondInfoForm Members

        public string NominalPriceText
        {
            get { return nominalPriceTextBox.Text; }
            set { InvokeIfRequired(() => nominalPriceTextBox.Text = value); }
        }

        public string CurrentPriceText
        {
            get { return currentPriceTextBox.Text; }
            set { InvokeIfRequired(() => currentPriceTextBox.Text = value); }
        }

        public string MaturityText
        {
            get { return maturityTextBox.Text; }
            set { InvokeIfRequired(() => maturityTextBox.Text = value); }
        }

        #endregion ICommonBondInfoForm Members
    }
}