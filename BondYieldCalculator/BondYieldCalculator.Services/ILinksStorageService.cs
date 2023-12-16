namespace BondYieldCalculator.Services
{
    public interface ILinksStorageService
    {
        bool IsExists { get; }

        IEnumerable<string>? GetLinks();

        void Save(IEnumerable<string?> links);
    }
}
