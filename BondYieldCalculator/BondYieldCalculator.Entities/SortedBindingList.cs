namespace BondYieldCalculator.Entities
{
    using System.ComponentModel;

    public class SortedBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor _sortProperty;

        public SortedBindingList(List<T> elements) : base(elements) { }

        protected override bool IsSortedCore => _isSorted;

        protected override bool SupportsSortingCore => true;

        protected override ListSortDirection SortDirectionCore => _sortDirection;

        protected override PropertyDescriptor SortPropertyCore => _sortProperty;

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            _sortProperty = property;
            _sortDirection = direction;

            if (_sortProperty is null)
            {
                return; // Nothing to sort on.
            }

            var list = Items as List<T>;
            if (list is null)
            {
                return;
            }

            list.Sort(Compare);
            _isSorted = true;

            // Fire an event that the list has been changed.
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
        }

        private int Compare(T leftItem, T rightItem)
        {
            var result = 0;
            var leftItemValue = leftItem is not null ? _sortProperty.GetValue(leftItem) : null;
            var rightItemValue = rightItem is not null ? _sortProperty.GetValue(rightItem) : null;

            if (rightItemValue is null && leftItemValue is null)
            {
                result = 0;
            }
            else
            {
                if (leftItemValue is null)
                {
                    result = -1;
                }
                else if (rightItemValue is null)
                {
                    result = 1;
                }
                else
                {
                    if (leftItemValue is IComparable)
                    {
                        result = ((IComparable)leftItemValue).CompareTo(rightItemValue);
                    }
                    else if (!leftItemValue.Equals(rightItemValue)) // Not comparable, compare ToString.
                    {
                        result = leftItemValue.ToString()!.CompareTo(rightItemValue.ToString());
                    }
                }
            }

            if (_sortDirection == ListSortDirection.Descending)
            {
                result = -result;
            }

            return result;
        }
    }
}
