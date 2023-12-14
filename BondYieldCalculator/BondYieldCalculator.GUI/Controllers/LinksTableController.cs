namespace BondYieldCalculator.GUI.Controllers
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.Entities.CustomEventArgs;
    using BondYieldCalculator.Entities.Dto;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal class LinksTableController : ILinksTableController, ILinksSelectionController
    {
        private readonly ILinksTableView _linksTableView;
        private readonly IControlsStateManagementController _controlsStateManagementController;
        private readonly SortedBindingList<BondLinkRowItem> _bindingList;
        private readonly List<BondLinkRowItem> _linkRowItems;

        private int _lastSelectedRowIndex = -1;

        public LinksTableController(ILinksTableView linksTableView, IControlsStateManagementController controlsStateManagementController)
        {
            _linksTableView = linksTableView;
            _controlsStateManagementController = controlsStateManagementController;
            _linkRowItems = new List<BondLinkRowItem>();
            _bindingList = new SortedBindingList<BondLinkRowItem>(_linkRowItems);

            LinksTable.AutoGenerateColumns = false;
            LinksTable.DataSource = _bindingList;
            LinksTable.SelectionChanged += (sender, args) => HandleSelectionChanged();

            _controlsStateManagementController.SetRowsCountControlsState(false);
        }

        #region ILinksTableController Members

        public int LinksCount => _linkRowItems.Count;

        public void AddLinkRow(string? link, bool selectRow = false)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return;
            }

            if (_linkRowItems.Any(item => item.Link == link))
            {
                MessageBox.Show("Данная ссылка уже была добавлена.", "Добавление ссылки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var linkRowItem = new BondLinkRowItem { Link = link };
            _bindingList.Add(linkRowItem);
            _controlsStateManagementController.SetRowsCountControlsState(true);

            if (!selectRow)
            {
                return;
            }

            foreach (DataGridViewRow row in LinksTable.Rows)
            {
                if (row.DataBoundItem is not null && row.DataBoundItem is BondLinkRowItem item)
                {
                    if (item != linkRowItem)
                    {
                        row.Selected = false;
                    }
                    else
                    {
                        row.Selected = true;
                        LinksTable.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
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

                _bindingList.Remove(item);
                yield return item.Link;
            }

            if (LinksCount == 0)
            {
                _controlsStateManagementController.SetRowsCountControlsState(false);
                yield break;
            }

            _controlsStateManagementController.SetRowsCountControlsState(true);
            SelectionChanged?.Invoke(this, new SelectionChangedEventArgs(GetSelectedBondLinkRowItem()));
        }

        public void ClearTable()
        {
            _bindingList.Clear();
            _controlsStateManagementController.SetRowsCountControlsState(false);
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

            _bindingList.ResetItem(_bindingList.IndexOf(linkRowItem));
        }

        public IEnumerable<string?> GetLinks() => _linkRowItems.Select(item => item.Link);

        #endregion ILinksTableController Members

        #region ILinksSelectionController Members

        public void ClearSelection() => LinksTable.ClearSelection();

        public BondLinkRowItem? GetSelectedBondLinkRowItem()
        {
            var selectedRows = GetSelectedRows().ToList();
            return selectedRows.Count == 1 && selectedRows[0].DataBoundItem is not null ? selectedRows[0].DataBoundItem as BondLinkRowItem : null;
        }

        public event EventHandler<SelectionChangedEventArgs> SelectionChanged = delegate { };

        #endregion ILinksSelectionController Members

        #region Private Members

        private DataGridView LinksTable => _linksTableView.LinksTable;

        private IEnumerable<DataGridViewRow> GetSelectedRows()
        {
            var rowIndexes = LinksTable.SelectedCells?
                .OfType<DataGridViewCell>()
                .Select(cell => cell.RowIndex)
                .Distinct()
                .OrderByDescending(index => index);
            if (rowIndexes is null)
            {
                yield break;
            }

            foreach (var rowIndex in rowIndexes)
            {
                yield return LinksTable.Rows[rowIndex];
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

            SelectionChanged?.Invoke(this, new SelectionChangedEventArgs(GetSelectedBondLinkRowItem()));
        }

        #endregion Private Members
    }
}
