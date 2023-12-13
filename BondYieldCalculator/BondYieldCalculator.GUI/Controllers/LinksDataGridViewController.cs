namespace BondYieldCalculator.GUI.Controllers
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;

    internal class LinksDataGridViewController : ILinksDataGridViewController, IBondLinkRowSelectionController
    {
        private readonly ILinksDataGridViewForm _form;
        private readonly IControlsStateController _controlsStateController;
        private readonly BindingSource _bindingSource;
        private readonly List<BondLinkRowItem> _linkRowItems;

        private int _lastSelectedRowIndex = -1;

        public LinksDataGridViewController(ILinksDataGridViewForm form, IControlsStateController controlsStateController)
        {
            _form = form;
            _controlsStateController = controlsStateController;
            _linkRowItems = new List<BondLinkRowItem>();
            _bindingSource = new BindingSource { DataSource = _linkRowItems };

            DataGridView.AutoGenerateColumns = false;
            DataGridView.DataSource = _bindingSource;
            DataGridView.SelectionChanged += (sender, args) => HandleSelectionChanged();

            _controlsStateController.SetDependenceFromRowsCountControlsState(false);
        }

        #region ILinksDataGridViewController Members

        public int LinksCount => _linkRowItems.Count;

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

            _bindingSource.Add(new BondLinkRowItem { Link = link });
            _controlsStateController.SetDependenceFromRowsCountControlsState(true);
        }

        public IEnumerable<string?> RemoveSelectedLinkRows()
        {
            var selectedRows = GetSelectedRows();
            if (selectedRows is null)
            {
                yield break;
            }

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                if (selectedRow?.DataBoundItem is null || selectedRow.DataBoundItem is not BondLinkRowItem item)
                {
                    continue;
                }

                _bindingSource.Remove(item);
                yield return item.Link;
            }

            _controlsStateController.SetDependenceFromRowsCountControlsState(LinksCount != 0);
        }

        public void ClearTable()
        {
            _bindingSource.Clear();
            _controlsStateController.SetDependenceFromRowsCountControlsState(false);
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
            linkRowItem.Maturity = bondInfo.CommonInfo?.Maturity;
            linkRowItem.RealYieldPercent = bondInfo.YieldInfo?.RealYieldPercent;

            RefreshDataSource();
        }

        public IEnumerable<string?> GetLinks() => _linkRowItems.Select(item => item.Link);

        #endregion ILinksDataGridViewController Members

        #region IBondLinkRowSelectionController Members

        public void ClearSelection() => DataGridView.ClearSelection();

        public BondLinkRowItem? GetSelectedBondLinkRowItem()
        {
            var selectedRows = GetSelectedRows().ToList();
            return selectedRows.Count == 1 && selectedRows[0].DataBoundItem is not null ? selectedRows[0].DataBoundItem as BondLinkRowItem : null;
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

        private IEnumerable<DataGridViewRow> GetSelectedRows()
        {
            var rowIndexes = DataGridView.SelectedCells
                .OfType<DataGridViewCell>()
                .Select(cell => cell.RowIndex)
                .Distinct()
                .OrderByDescending(index => index);
            foreach (var rowIndex in rowIndexes)
            {
                yield return DataGridView.Rows[rowIndex];
            }
        }

        private void HandleSelectionChanged()
        {
            var selectedRows = GetSelectedRows().ToList();
            if (selectedRows.Count != 1 || _lastSelectedRowIndex == selectedRows[0].Index)
            {
                return;
            }

            _lastSelectedRowIndex = selectedRows[0].Index;
            var hasLinkRowItems = _linkRowItems.Count != 0;

            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }

        private void HandleColumnHeaderMouseClick(DataGridViewCellMouseEventArgs args)
        {
            ListSortDirection direction;

            var newColumn = DataGridView.Columns[args.ColumnIndex];
            var oldColumn = DataGridView.SortedColumn;

            if (oldColumn == newColumn)
            {
                direction = DataGridView.SortOrder == SortOrder.Ascending ? ListSortDirection.Descending : ListSortDirection.Ascending;
            }
            else
            {
                direction = ListSortDirection.Ascending;
                if (oldColumn != null)
                {
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }

            DataGridView.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        #endregion Private Members
    }
}
