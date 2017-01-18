using System.Configuration;

namespace TextListener
{
    internal class TextListenerConfigElement : ConfigurationElement
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
