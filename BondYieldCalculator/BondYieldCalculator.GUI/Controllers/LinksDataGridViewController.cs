namespace BondYieldCalculator.GUI.Controllers
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;

    internal class LinksDataGridViewController : ILinksDataGridViewController, IBondLinkRowSelectionController
    {
        private readonly ILinksDataGridViewForm _form;
        private readonly BindingSource _bindingSource;
        private readonly List<BondLinkRowItem> _linkRowItems;

        #region ILinksDataGridViewController Members

        public LinksDataGridViewController(ILinksDataGridViewForm form)
        {
            _form = form;
            _linkRowItems = new List<BondLinkRowItem>();
            _bindingSource = new BindingSource { DataSource = _linkRowItems };

            DataGridView.AutoGenerateColumns = false;
            DataGridView.DataSource = _bindingSource;

            DataGridView.SelectionChanged += (sender, args) => HandleSelectionChanged();
        }

        public void AddLinkRow(string? link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return;
            }

            if (_linkRowItems.Any(item => item.Link == link))
            {
                MessageBox.Show("Данная ссылка уже была добавлена.", "Добавление ссылки на облигацию", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = new BondLinkRowItem { Link = link };
            _bindingSource.Add(item);
        }

        public void RemoveSelectedLinkRows()
        {
            var selectedRows = DataGridView.SelectedRows;
            if (selectedRows is null)
            {
                return;
            }

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                if (selectedRow.DataBoundItem is null)
                {
                    continue;
                }

                if (selectedRow.DataBoundItem is BondLinkRowItem item)
                {
                    _bindingSource.Remove(item);
                }
            }

            DataGridView.Refresh();

            _form.RemoveButtonEnabled = _linkRowItems.Count != 0;
        }

        public void UpdateLinkRowItem(BondInfo? bondInfo)
        {
            if (bondInfo is null)
            {
                return;
            }

            var linkRowItem = _linkRowItems.FirstOrDefault(item => item.Link == bondInfo.Link);
            if (linkRowItem is null)
            {
                return;
            }

            linkRowItem.Name = bondInfo.CommonInfo?.Name;
            linkRowItem.RealYieldPercent = bondInfo.YieldInfo?.RealYieldPercent;

            RefreshDataSource();
        }

        public IEnumerable<string?> GetLinks() => _linkRowItems.Select(item => item.Link);

        #endregion ILinksDataGridViewController Members

        #region IBondLinkRowSelectionController Members

        public void ClearSelection() => DataGridView.ClearSelection();

        public BondLinkRowItem? GetSelectedBondLinkRowItem()
        {
            var selectedRow = GetSelectedDataGridViewRow();
            return selectedRow?.DataBoundItem as BondLinkRowItem;
        }

        public event EventHandler SelectionChanged = delegate { };

        #endregion IBondLinkRowSelectionController Members

        #region Private Members

        private DataGridView DataGridView => _form.LinksDataGridView;

        private void RefreshDataSource()
        {
            _bindingSource.DataSource = null;
            _bindingSource.DataSource = _linkRowItems;
        }

        private DataGridViewRow? GetSelectedDataGridViewRow()
        {
            var rowIndexes = DataGridView.SelectedCells
                .OfType<DataGridViewCell>()
                .Select(cell => cell.RowIndex)
                .Distinct()
                .ToList();
            if (rowIndexes.Count != 1)
            {
                return null;
            }

            var selectedRow = DataGridView.Rows[rowIndexes[0]];
            return selectedRow;
        }

        private void HandleSelectionChanged()
        {
            var selectedRow = GetSelectedDataGridViewRow();
            if (selectedRow is not null)
            {
                SelectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion Private Members
    }
}
