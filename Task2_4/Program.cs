using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;
using TextListener;

namespace Task2_4
{
    public class Program
    {
        private static void Main()
        {
            var logger = Logger.Logger.GetInstance("my Logger");
            var textListener = new TextListener.TextListener();
            var wordListener = new WordListener.WordListener();
            var eventLogListener = new EventLogListener.EventLogListener();
            logger.AddListener(textListener);
            logger.AddListener(wordListener);
            logger.AddListener(eventLogListener);
            logger.Log(LogLevel.Error, "Hello World");
            Console.WriteLine(logger.Name);
            Console.ReadKey();
        }
    }
}
