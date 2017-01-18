using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLogListener
{
    internal class EventLogListenerConfig : ConfigurationSection
    {
        [ConfigurationProperty("general", IsRequired = true)]
        public EventLogListenerConfigElement General => (EventLogListenerConfigElement)base["general"];
    }
}
