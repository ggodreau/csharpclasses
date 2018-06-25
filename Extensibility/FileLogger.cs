using System;
using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        void ILogger.LogError(string message)
        {
            Console.WriteLine("logging error to file...");
            Log("Error", message);
        }
        void ILogger.LogInfo(string message)
        {
            Console.WriteLine("logging info to file...");
            Log("Info", message);
        }
        private void Log(string errorType, string message)
        {
            using (var streamwriter = new StreamWriter(_path, true))
            {
                // need this using block to open a file, sry
                streamwriter.Write(errorType + ": " + message);
            }
        }
    }
}
