namespace BondYieldCalculator.Services
{
    public class ServicesCreator
    {
        public IConfigService CreateConfigService(string? fileName) => new ConfigService(fileName);

        public ILinksStorageService CreateLinksStorageService() => new LinksStorageService();

        public IYieldCalculatorService CreateYieldCalculatorService(string? fileName) => new YieldCalculatorService(CreateConfigService(fileName));

        public IYieldCalculatorService CreateYieldCalculatorService(IConfigService configService) => new YieldCalculatorService(configService);

        public ILogService CreateLogService() => new LogService();
    }
}
