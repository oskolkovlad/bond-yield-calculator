namespace BondYieldCalculator.GUI
{
    using BondYieldCalculator.GUI.Interfaces.Forms;

    public partial class Form : System.Windows.Forms.Form,
        ILinkForm,
        ILinksDataGridViewForm,
        ICommonBondInfoForm,
        ICouponInfoForm,
        IYieldInfoForm
    {
        public Form()
        {
            InitializeComponent();

            BondPanelEnabled = false;

            addButton.Click += (sender, args) => LinkAdded.Invoke(this, EventArgs.Empty);
            removeButton.Click += (sender, args) => LinksRemoved.Invoke(this, EventArgs.Empty);
            analyzeButton.Click += (sender, args) => LinksAnalyzed.Invoke(this, EventArgs.Empty);
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

        public string? LinkText
        {
            get { return linkTextBox.Text; }
            set { InvokeIfRequired(() => linkTextBox.Text = value); }
        }

        public event EventHandler LinkAdded = delegate { };

        public event EventHandler LinksRemoved = delegate { };

        public event EventHandler LinksAnalyzed = delegate { };

        #endregion ILinkForm Members

        #region ILinksDataGridViewForm Members

        public bool RemoveButtonEnabled
        {
            get { return removeButton.Enabled; }
            set { InvokeIfRequired(() => removeButton.Enabled = value); }
        }

        public DataGridView LinksDataGridView => linksDataGridView;

        #endregion ILinksDataGridViewForm Members

        #region ICommonBondInfoForm Members

        public string? NameText
        {
            get { return nameTextBox.Text; }
            set { InvokeIfRequired(() => nameTextBox.Text = value); }
        }

        public string? NominalPriceText
        {
            get { return nominalPriceTextBox.Text; }
            set { InvokeIfRequired(() => nominalPriceTextBox.Text = value); }
        }

        public string? CurrentPriceText
        {
            get { return currentPriceTextBox.Text; }
            set { InvokeIfRequired(() => currentPriceTextBox.Text = value); }
        }

        public string? MaturityText
        {
            get { return maturityTextBox.Text; }
            set { InvokeIfRequired(() => maturityTextBox.Text = value); }
        }

        #endregion ICommonBondInfoForm Members

        #region ICouponInfoForm Members

        public string? AccumulatedCouponIncomeText
        {
            get { return accumulatedCouponIncomeTextBox.Text; }
            set { InvokeIfRequired(() => accumulatedCouponIncomeTextBox.Text = value); }
        }

        public string? CouponText
        {
            get { return couponTextBox.Text; }
            set { InvokeIfRequired(() => couponTextBox.Text = value); }
        }

        public string? CouponsQuantityText
        {
            get { return couponsQuantityTextBox.Text; }
            set { InvokeIfRequired(() => couponsQuantityTextBox.Text = value); }
        }

        public string? QuantityOfPaymentsInYearText
        {
            get { return quantityOfPaymentsInYearTextBox.Text; }
            set { InvokeIfRequired(() => quantityOfPaymentsInYearTextBox.Text = value); }
        }

        #endregion ICouponInfoForm Members

        #region IYieldInfoForm Members

        public string? YieldText
        {
            get { return yieldTextBox.Text; }
            set { InvokeIfRequired(() => yieldTextBox.Text = value); }
        }

        public string? CapitalGainsPercentText
        {
            get { return capitalGainsPercentTextBox.Text; }
            set { InvokeIfRequired(() => capitalGainsPercentTextBox.Text = value); }
        }

        public string? RealCouponIncomeText
        {
            get { return realCouponIncomeTextBox.Text; }
            set { InvokeIfRequired(() => realCouponIncomeTextBox.Text = value); }
        }

        public string? RealCouponIncomePercentText
        {
            get { return realCouponIncomePercentTextBox.Text; }
            set { InvokeIfRequired(() => realCouponIncomePercentTextBox.Text = value); }
        }

        public string? RealYieldPercentText
        {
            get { return realYieldPercentTextBox.Text; }
            set { InvokeIfRequired(() => realYieldPercentTextBox.Text = value); }
        }

        #endregion IYieldInfoForm Members
    }
}