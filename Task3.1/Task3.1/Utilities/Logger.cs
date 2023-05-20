
using NLog;

namespace Task3._1.Utilities
{
    public static class Logg
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        public static void debugMessage(string text)
        {
            logger.Debug(text);
        }

        public static void infoMessage(string text)
        {
            logger.Info(text);
        }

        public static void loadLoggerConfig()
        {
            LogManager.LoadConfiguration("C:\\Users\\setos\\source\\repos\\s.martinezrepo\\Task3.1\\Task3.1\\Files\\nlog.config");
        }
}
}

