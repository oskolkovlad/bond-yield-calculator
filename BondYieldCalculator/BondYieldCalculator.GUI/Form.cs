namespace BondYieldCalculator.GUI
{
    using BondYieldCalculator.GUI.Interfaces.Forms;

    public partial class Form : System.Windows.Forms.Form,
        ILinksForm,
        ILinksDataGridViewForm,
        IControlsStateForm,
        ICommonBondInfoForm,
        ICouponInfoForm,
        IYieldInfoForm
    {
        public Form()
        {
            InitializeComponent();

            BondPanelEnabled = false;

            addLinkButton.Click += (sender, args) => LinkAdding.Invoke(this, EventArgs.Empty);
            removeLinksButton.Click += (sender, args) => LinksRemoving.Invoke(this, EventArgs.Empty);
            analyzeButton.Click += (sender, args) => LinksAnalyzing.Invoke(this, EventArgs.Empty);
            restoreLinksButton.Click += (sender, args) => LinksRestoring.Invoke(this, EventArgs.Empty);
            saveLinksButton.Click += (sender, args) => LinksSaving.Invoke(this, EventArgs.Empty);
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

        #region ILinksForm Members

        public string? LinkText
        {
            get { return linkTextBox.Text; }
            set { InvokeIfRequired(() => linkTextBox.Text = value); }
        }

        public event EventHandler LinkAdding = delegate { };

        public event EventHandler LinksRemoving = delegate { };

        public event EventHandler LinksAnalyzing = delegate { };

        public event EventHandler LinksRestoring = delegate { };

        public event EventHandler LinksSaving = delegate { };

        #endregion ILinksForm Members

        #region ILinksDataGridViewForm Members

        public DataGridView LinksDataGridView => linksDataGridView;

        #endregion ILinksDataGridViewForm Members

        #region IControlsStateForm Members

        public bool LintTextBoxEnabled
        {
            get { return linkTextBox.Enabled; }
            set { InvokeIfRequired(() => linkTextBox.Enabled = value); }
        }

        public bool AddLinkButtonEnabled
        {
            get { return addLinkButton.Enabled; }
            set { InvokeIfRequired(() => addLinkButton.Enabled = value); }
        }

        public bool RemoveLinksButtonEnabled
        {
            get { return removeLinksButton.Enabled; }
            set { InvokeIfRequired(() => removeLinksButton.Enabled = value); }
        }

        public bool AnalyzeButtonEnabled
        {
            get { return analyzeButton.Enabled; }
            set { InvokeIfRequired(() => analyzeButton.Enabled = value); }
        }

        public bool RestoreLinksButtonEnabled
        {
            get { return restoreLinksButton.Enabled; }
            set { InvokeIfRequired(() => restoreLinksButton.Enabled = value); }
        }

        public bool SaveLinksButtonEnabled
        {
            get { return saveLinksButton.Enabled; }
            set { InvokeIfRequired(() => saveLinksButton.Enabled = value); }
        }

        public bool BondPanelEnabled
        {
            get { return bondTableLayoutPanel.Enabled; }
            set { InvokeIfRequired(() => bondTableLayoutPanel.Enabled = value); }
        }

        #endregion IControlsStateForm Members

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