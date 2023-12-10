using BondYieldCalculator.Entities;

namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    internal interface IBondLinkRowSelectionController : IController
    {
        void ClearSelection();

        BondLinkRowItem? GetSelectedBondLinkRowItem();

        event EventHandler SelectionChanged;
    }
}
