namespace BondYieldCalculator.GUI.ViewControls.Views
{
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal partial class LinksTableView : UserControl, ILinksTableView, ILinksManagementView, ILinksControlsStateManagementView
    {
        public LinksTableView()
        {
            InitializeComponent();

            addLinkButton.Click += (sender, args) => LinkAdding.Invoke(this, EventArgs.Empty);
            removeLinksButton.Click += (sender, args) => LinksRemoving.Invoke(this, EventArgs.Empty);
            analyzeButton.Click += (sender, args) => LinksAnalyzing.Invoke(this, EventArgs.Empty);
            restoreLinksButton.Click += (sender, args) => LinksRestoring.Invoke(this, EventArgs.Empty);
            saveLinksButton.Click += (sender, args) => LinksSaving.Invoke(this, EventArgs.Empty);
        }

        #region ILinksTableView Members

        public DataGridView LinksTable => linksTable;

        #endregion ILinksTableView Members

        #region ILinksManagementView Members

        public string? LinkText
        {
            get { return linkTextBox.Text; }
            set { this.InvokeIfRequired(() => linkTextBox.Text = value); }
        }

        public event EventHandler LinkAdding = delegate { };

        public event EventHandler LinksRemoving = delegate { };

        public event EventHandler LinksAnalyzing = delegate { };

        public event EventHandler LinksRestoring = delegate { };

        public event EventHandler LinksSaving = delegate { };

        #endregion ILinksManagementView Members

        #region ILinksControlsStateManagementView Members

        public bool LintTextBoxEnabled
        {
            get { return linkTextBox.Enabled; }
            set { this.InvokeIfRequired(() => linkTextBox.Enabled = value); }
        }

        public bool AddLinkButtonEnabled
        {
            get { return addLinkButton.Enabled; }
            set { this.InvokeIfRequired(() => addLinkButton.Enabled = value); }
        }

        public bool RemoveLinksButtonEnabled
        {
            get { return removeLinksButton.Enabled; }
            set { this.InvokeIfRequired(() => removeLinksButton.Enabled = value); }
        }

        public bool AnalyzeButtonEnabled
        {
            get { return analyzeButton.Enabled; }
            set { this.InvokeIfRequired(() => analyzeButton.Enabled = value); }
        }

        public bool RestoreLinksButtonEnabled
        {
            get { return restoreLinksButton.Enabled; }
            set { this.InvokeIfRequired(() => restoreLinksButton.Enabled = value); }
        }

        public bool SaveLinksButtonEnabled
        {
            get { return saveLinksButton.Enabled; }
            set { this.InvokeIfRequired(() => saveLinksButton.Enabled = value); }
        }

        #endregion ILinksControlsStateManagementView Members
    }
}
