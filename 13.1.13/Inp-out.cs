using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13._1._13
{
    class Inp_out
    {
        public static string Read(string filename)
        {
            string text = "";

            StreamReader reader = new StreamReader(filename);

            text = reader.ReadToEnd();

            reader.Close();

            return text;
        }

        // Возвращает путь к папке с файлами данных
        public static string GetDataDirectiry()
        {
            return "\\..\\..\\..\\Data\\";
        }

        public static void Write(string filename, string text)
        {
            File.WriteAllText(filename, text);
        }
    }
}
