namespace BondYieldCalculator.GUI.Services
{
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Services;
    using Microsoft.Extensions.Configuration;

    internal class ConfigService : IConfigService
    {
        private readonly string _fileName;

        private Lazy<Config> _config;

        public ConfigService(string fileName)
        {
            _fileName = fileName;
            _config = new Lazy<Config>(() => ReadJsonFromFile(_fileName));
        }

        public Config Instance => _config.Value;

        public void Refresh()
        {
            if (_config.IsValueCreated)
            {
                _config = new Lazy<Config>(() => ReadJsonFromFile(_fileName));
            }
        }

        private static Config ReadJsonFromFile(string fileName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(fileName);
            var configuration = builder.Build();

            return configuration.Get<Config>()!;
        }
    }
}
