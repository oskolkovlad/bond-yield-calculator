namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.Entities.CustomEventArgs;

    internal interface ILinksSelectionController : IController
    {
        void ClearSelection();

        BondLinkRowItem? GetSelectedBondLinkRowItem();

        event EventHandler<SelectionChangedEventArgs> SelectionChanged;
    }
}
