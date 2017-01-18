using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class LoggerConfig : ConfigurationSection
    {
        [ConfigurationProperty("general", IsRequired = false)]
        public LoggerConfigElement General => (LoggerConfigElement)base["general"];
    }
}
