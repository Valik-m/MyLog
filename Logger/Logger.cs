using System;
using System.Collections.Generic;
using System.Configuration;
using Listener;

namespace Logger
{
    public class Logger: ILogger
    {
        private static Logger _instance;

        private readonly List<IListener> _listeners = new List<IListener>(); 

        public string Name { get; }

        protected Logger()
        {
            var config = (LoggerConfig) ConfigurationManager.GetSection("LoggerSettings");
            Name = config.General.Name;
        }

        public static Logger GetInstance(string name)
        {
            return _instance ?? (_instance = new Logger());
        }

        public void AddListener(IListener listener)
        {
            if (listener == null) return;
            _listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {
            if (listener == null) return;
            _listeners.Remove(listener);
        }

        public void Log(LogLevel logLevel, string message)
        {
            foreach (var listener in _listeners)
            {
                switch (logLevel)
                {
                    case LogLevel.Info:
                        listener.Info(message);
                        break;
                    case LogLevel.Warn:
                        listener.Warn(message);
                        break;
                    case LogLevel.Error:
                        listener.Error(message);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null);
                }
            }
        }

        public void Load()
        {
            
        }
    }
}
