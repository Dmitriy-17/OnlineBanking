namespace OnlineBanking.Service
{
    interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}
