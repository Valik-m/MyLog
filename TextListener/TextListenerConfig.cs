using System.Configuration;

namespace TextListener
{
    internal class TextListenerConfig : ConfigurationSection
    {
        [ConfigurationProperty("general", IsRequired = true)]
        public TextListenerConfigElement General => (TextListenerConfigElement)base["general"];
    }
}
