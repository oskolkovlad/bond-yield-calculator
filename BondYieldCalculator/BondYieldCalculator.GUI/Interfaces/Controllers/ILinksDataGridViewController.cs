namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    using BondYieldCalculator.Entities;

    internal interface ILinksDataGridViewController : IController
    {
        int LinksCount { get; }

        void AddLinkRow(string? link);

        IEnumerable<string?> RemoveSelectedLinkRows();

        void UpdateLinkRowItem(BondInfo? bondInfo);

        IEnumerable<string?> GetLinks();
    }
}
