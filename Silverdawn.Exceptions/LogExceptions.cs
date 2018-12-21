using System;
using System.Diagnostics;


namespace Silverdawn.Exceptions
{
    public interface ILogExceptions
    {
        void Log(LogLevel level, Exception ex, string message = "");
        void Log(LogLevel level, string message);
    }

    public class LogExceptions : ILogExceptions
    {

        public void Log(LogLevel level, Exception ex, string message = "")
        {
            Console.WriteLine(level.ToString() + ": ");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);

        }

        public void Log(LogLevel level, string message)
        {
            Console.WriteLine(level.ToString() + ": " + message);

        }

    }


    public class LogFactory
    {
        public static ILogExceptions GetLogger()
        {
            return new LogExceptions();
        }

    }

    public enum LogLevel
    {
        Error,
        Warn,
        Info,
        Debug
    }

}
