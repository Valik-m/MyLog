using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listener;
using System.Configuration;
using System.IO;

namespace TextListener
{
    public class TextListener: IListener
    {
        private readonly string _path;

        private readonly string _fileName;

        public TextListener()
        {
            var s = (TextListenerConfig)ConfigurationManager.GetSection("TextListenerSettings");
            _path = s.General.Path;
            _fileName = s.General.FileName;   
        }

        public void Warn(string message)
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
            using (var file = new StreamWriter(Path.Combine(_path, _fileName), true))
            {
                file.WriteLine($"Warning: {message}", true);
            }
        }

        public void Info(string message)
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
            using (var file = new StreamWriter(Path.Combine(_path, _fileName), true))
            {
                file.WriteLine($"Info: {message}", true);
            }
        }

        public void Error(string message)
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
            using (var file = new StreamWriter(Path.Combine(_path, _fileName), true))
            {
                file.WriteLine($"Error: {message}", true);
            }
        }
    }
}
