using BondYieldCalculator.Entities;

namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    internal interface ILinksSelectionController : IController
    {
        void ClearSelection();

        BondLinkRowItem? GetSelectedBondLinkRowItem();

        event EventHandler SelectionChanged;
    }
}
