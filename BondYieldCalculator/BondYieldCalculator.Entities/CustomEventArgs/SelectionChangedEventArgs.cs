namespace BondYieldCalculator.Entities.CustomEventArgs
{
    public class SelectionChangedEventArgs
    {
        public SelectionChangedEventArgs(BondLinkRowItem? item) => Item = item;

        public BondLinkRowItem? Item { get; }
    }
}
