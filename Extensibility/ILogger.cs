namespace Extensibility
{
    public interface ILogger
    {
        void LogError(string messsage);
        void LogInfo(string messsage);
    }
}