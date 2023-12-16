namespace BondYieldCalculator.Services
{
    public interface ILogService : IService
    {
        void LogTrace(string message);

        void LogTrace(string message, Exception exception);

        void LogDebug(string message);

        void LogDebug(string message, Exception exception);

        void LogInfo(string message);

        void LogInfo(string message, Exception exception);

        void LogWarn(string message);

        void LogWarn(string message, Exception exception);

        void LogError(string message);

        void LogError(string message, Exception exception);

        void LogFatal(string message);

        void LogFatal(string message, Exception exception);
    }
}
