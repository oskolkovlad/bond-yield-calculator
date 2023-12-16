namespace BondYieldCalculator.Services
{
    public interface ILinksStorageService : IService
    {
        bool IsExists { get; }

        IEnumerable<string>? GetLinks();

        void Save(IEnumerable<string?> links);
    }
}
