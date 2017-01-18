using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listener;

namespace EventLogListener
{
    public class EventLogListener : IListener
    {
        private readonly EventLog _eventLog;

        public EventLogListener()
        {
            _eventLog = new EventLog("Application") { Source = "Application" };
        }

        public void Warn(string message)
        {
            _eventLog.WriteEntry(message, EventLogEntryType.Warning); 
        }

        public void Info(string message)
        {
            _eventLog.WriteEntry(message, EventLogEntryType.Information);
        }

        public void Error(string message)
        {
            _eventLog.WriteEntry(message, EventLogEntryType.Error);
        }
    }
}
