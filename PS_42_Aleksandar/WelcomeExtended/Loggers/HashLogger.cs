using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    internal class HashLogger : ILogger
    {
        static ConcurrentDictionary<int, string> _logMessages = new ConcurrentDictionary<int, string>();
        private string _name;

        public HashLogger(string name)
        {
            _name = name;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            var message = formatter(state, exception);

            switch(logLevel)
            {
                case LogLevel.Critical:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine("- LOGGER -");
            var messageToBeLogged = new StringBuilder();
            messageToBeLogged.Append($"[{logLevel}]");
            messageToBeLogged.AppendFormat($" [{_name}]");
            _logMessages[eventId.Id] = message;
            WriteAll();
        }

        public void WriteLogId(int id)
        {
            Console.WriteLine(_logMessages[id]);
            Console.WriteLine("- LOGGER -");
            Console.ResetColor();
        }
        public void WriteAll()
        {
            int i;
            for (i = 0; i < _logMessages.Count; i++)
            {
                WriteLogId(i);
            }
            Console.WriteLine($"{i}");
        }
    }
}
