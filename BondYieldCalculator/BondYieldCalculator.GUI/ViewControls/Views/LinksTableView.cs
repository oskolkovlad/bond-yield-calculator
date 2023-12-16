namespace BondYieldCalculator.GUI.ViewControls.Views
{
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal partial class LinksTableView : UserControl,
        ILinksTableView,
        ILinksShortcutsView,
        ILinksManagementView,
        ILinksControlsStateManagementView
    {
        public LinksTableView()
        {
            InitializeComponent();

            linkTextBox.KeyDown += (sender, args) => LinkTextBoxKeyDown.Invoke(this, args);
            addLinkButton.Click += (sender, args) => LinkAdding.Invoke(this, args);
            removeLinksButton.Click += (sender, args) => LinksRemoving.Invoke(this, args);
            analyzeButton.Click += (sender, args) => LinksAnalyzing.Invoke(this, args);
            restoreLinksButton.Click += (sender, args) => LinksRestoring.Invoke(this, args);
            saveLinksButton.Click += (sender, args) => LinksSaving.Invoke(this, args);
        }

        #region ILinksTableView Members

        public DataGridView LinksTable => linksTable;

        #endregion ILinksTableView Members

        #region ILinksShortcutsView Members

        public event KeyEventHandler LinkTextBoxKeyDown = delegate { };

        #endregion ILinksShortcutsView Members

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
