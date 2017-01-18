using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listener;
using Novacode;

namespace WordListener
{
    public class WordListener : IListener
    {
        private readonly string _path;

        private readonly string _fileName;

        private DocX _doc; 

        public WordListener()
        {
            var s = (WordListenerConfig)ConfigurationManager.GetSection("WordListenerSettings");
            _path = s.General.Path;
            _fileName = s.General.FileName;
        }

        public void Warn(string message)
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
            _doc = !File.Exists(Path.Combine(_path, _fileName)) ? DocX.Create(Path.Combine(_path, _fileName)) : DocX.Load(Path.Combine(_path, _fileName));
            _doc.InsertParagraph($"Warning: {message}");
            _doc.Save();
        }

        public void Info(string message)
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
            _doc = !File.Exists(Path.Combine(_path, _fileName)) ? DocX.Create(Path.Combine(_path, _fileName)) : DocX.Load(Path.Combine(_path, _fileName));
            _doc.InsertParagraph($"Info: {message}");
            _doc.Save();
        }

        public void Error(string message)
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
            _doc = !File.Exists(Path.Combine(_path, _fileName)) ? DocX.Create(Path.Combine(_path, _fileName)) : DocX.Load(Path.Combine(_path, _fileName));
            _doc.InsertParagraph($"Error: {message}");
            _doc.Save();
        }
    }
}
