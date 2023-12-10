namespace BondYieldCalculator.GUI.Services
{
    using BondYieldCalculator.GUI.Interfaces.Services;

    internal class LinksStorageService : ILinksStorageService
    {
        private const string FileName = "SavedLinks.ini";

        public bool IsExists => File.Exists(FileName);

        public IEnumerable<string>? GetLinks() => IsExists ? File.ReadAllText(FileName).Split('\n') : null;

        public void Save(IEnumerable<string?> links) => File.WriteAllText(FileName, string.Join("\n", links));
    }
}
