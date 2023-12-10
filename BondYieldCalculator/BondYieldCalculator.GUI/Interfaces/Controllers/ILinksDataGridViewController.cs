namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    using BondYieldCalculator.Entities;

    internal interface ILinksDataGridViewController : IController
    {
        void AddLinkRow(string? link);

        void RemoveSelectedLinkRows();

        void UpdateLinkRowItem(BondInfo? bondInfo);

        IEnumerable<string?> GetLinks();
    }
}
