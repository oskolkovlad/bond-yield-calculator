namespace BondYieldCalculator.GUI.Interfaces.Services
{
    internal interface ILinksStorageService
    {
        bool IsExists { get; }

        IEnumerable<string>? GetLinks();

        void Save(IEnumerable<string?> links);
    }
}
