namespace BondYieldCalculator.Services
{
    using BondYieldCalculator.Entities.Dto;
    using Microsoft.Extensions.Configuration;

    internal class ConfigService : IConfigService
    {
        private readonly string? _fileName;

        private Lazy<Config?> _config;

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public ConfigService(string? fileName)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            _fileName = fileName;

            RefershInitialization();
        }

#pragma warning disable CS8766 // Допустимость значений NULL для ссылочных типов в типе возвращаемого значения не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).
        public Config? Instance => _config.Value;
#pragma warning restore CS8766 // Допустимость значений NULL для ссылочных типов в типе возвращаемого значения не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).

        public void Refresh()
        {
            if (_config.IsValueCreated)
            {
                RefershInitialization();
            }
        }

        private void RefershInitialization() => _config = new Lazy<Config?>(() => ReadJsonFromFile(_fileName));

        private static Config? ReadJsonFromFile(string? fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return null;
            }

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(fileName);
            var configuration = builder.Build();

            return configuration.Get<Config>()!;
        }
    }
}
