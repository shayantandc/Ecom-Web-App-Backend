using NLog;



namespace Category.Logger
{
    public class LoggerService : ILoggerService
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }



        public void LogError(string message)
        {
            logger.Error(message);
        }



        public void LogInfo(string message)
        {
            logger.Info(message);
        }



        public void LogTrace(string message)
        {
            logger.Warn(message);
        }



        public void LogWarn(string message)
        {
            logger.Trace(message);
        }
    }
}

