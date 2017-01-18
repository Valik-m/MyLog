using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordListener
{
    internal class WordListenerConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("path", IsRequired = true)]
        public string Path
        {
            get { return (string)base["path"]; }
            set { base["path"] = value; }
        }

        [ConfigurationProperty("fileName", IsRequired = true)]
        public string FileName
        {
            get { return (string)base["fileName"]; }
            set { base["fileName"] = value; }
        }
    }
}
