namespace BondYieldCalculator.Services
{
    using NLog;

    internal class LogService : ILogService
    {
        private Logger _logger = LogManager.GetCurrentClassLogger();

        public void LogTrace(string message) => _logger.Trace(message);

        public void LogTrace(string message, Exception exception) => _logger.Trace(message, exception);

        public void LogDebug(string message) => _logger.Debug(message);

        public void LogDebug(string message, Exception exception) => _logger.Debug(message, exception);

        public void LogInfo(string message) => _logger.Info(message);

        public void LogInfo(string message, Exception exception) => _logger.Error(message, exception);

        public void LogWarn(string message) => _logger.Warn(message);

        public void LogWarn(string message, Exception exception) => _logger.Error(message, exception);

        public void LogError(string message) => _logger.Error(message);

        public void LogError(string message, Exception exception) => _logger.Error(message, exception);

        public void LogFatal(string message) => _logger.Fatal(message);

        public void LogFatal(string message, Exception exception) => _logger.Fatal(message, exception);
    }
}
