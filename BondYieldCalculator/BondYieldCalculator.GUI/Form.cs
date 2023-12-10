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

        #region ILinkForm Members

        public bool BondPanelEnabled
        {
            get { return bondTableLayoutPanel.Enabled; }
            set { bondTableLayoutPanel.Enabled = value; }
        }

        public string LinkText
        {
            get { return linkTextBox.Text; }
            set { linkTextBox.Text = value; }
        }

        public event EventHandler AnalyzeBond;

        #endregion ILinkForm Members
    }
}