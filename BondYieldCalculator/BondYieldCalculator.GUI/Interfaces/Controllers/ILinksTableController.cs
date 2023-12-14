namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    using BondYieldCalculator.Entities.Dto;

    internal interface ILinksTableController : IController
    {
        int LinksCount { get; }

        void AddLinkRow(string? link);

        IEnumerable<string?> RemoveSelectedLinkRows();

        void ClearTable();

        void UpdateLinkRowItem(BondInfo? bondInfo);

        IEnumerable<string?> GetLinks();
    }
}
