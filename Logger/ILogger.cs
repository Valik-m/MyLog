using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listener;

namespace Logger
{
    public interface ILogger
    {
        void AddListener(IListener listener);
        void RemoveListener(IListener listener);
        void Log(LogLevel logLevel, string message);
    }
}
