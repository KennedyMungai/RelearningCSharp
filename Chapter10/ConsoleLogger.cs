using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

using static System.Console;

namespace Packt.Shared
{
    public class ConsoleLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            //We could have different logger implementations for
            //different categoryName values but we only have one
            return new ConsoleLogger();
        }

        //If your logger uses some unmanaged resources,
        //then you can release them here
        public void Dispose() { }
    }

    public class ConsoleLogger : ILogger
    {
        //If your logger uses unmanaged resources,you can return 
        //the clas that implements IDisposable here
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            //To avoid overlogging, you can filter on the log level
            switch (logLevel)
            {
                case LogLevel.Trace:
                case LogLevel.Debug:
                case LogLevel.Information:
                case LogLevel.Warning:
                case LogLevel.Error:
                case LogLevel.Critical:
                case LogLevel.None:
                    return false;
                default:
                    return true;
            };
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception, string> func)
        {
            //Log the level and event identifier
            Write($"Level: {logLevel}, Event Id: {eventId.Id}");
            // only output the state or exception if it exists
            if (state != null)
            {
                Write($", State: {state}");
            }
            if (exception != null)
            {
                Write($", Exception: {exception.Message}");
            }
            WriteLine();
        }
    }
}
