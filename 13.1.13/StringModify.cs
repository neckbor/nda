using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1._13
{
    class StringModify
    {
        private string _text;
        private string _filename;

        public StringModify(string filename)
        {
            _text = Inp_out.Read(filename);
            _filename = filename;
        }

        public string GetText()
        {
            return _text;
        }

        //Убираем дишние пробелы
        public void DeleteSpaces()
        {
            while (_text.Contains("  "))
                _text = _text.Replace("  ", " ");
        }

        public void WriteFile()
        {
            Inp_out.Write(_filename, _text);
        }
    }
}
