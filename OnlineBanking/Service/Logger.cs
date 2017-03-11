using log4net;
using log4net.Config;
using WebGrease.Activities;

namespace OnlineBanking.Service
{
    public class Logger : ILogger
    {
        private static ILog _log = LogManager.GetLogger("LOGGER");

        public static ILog Log
        {
            get { return _log; }
        }

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }

        public void LogError(string message)
        {
            Log.Error(message);
        }
        public void LogInfo(string message)
        {
            Log.Info(message);
        }
    }
}