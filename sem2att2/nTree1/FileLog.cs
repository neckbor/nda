using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nTree1
{
    class FileLog
    {
        // Возвращает путь к папке с файлами данных
        public static string GetDataDirectiry()
        {
            return "\\..\\..\\..\\Data\\";
        }

        public static string GetInputString()
        {
            string filename = "",
                    inpStr = "";

            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + FileLog.GetDataDirectiry());

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog.FileName;

                StreamReader reader = new StreamReader(filename);

                string str = reader.ReadLine();
                while (str != null)
                {
                    inpStr += ' ' + str;
                    str = reader.ReadLine();
                }

                reader.Close();
                //_queue = StrToQueue(input);
            }


            return inpStr;
        }

        public static void WriteFile(string line)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
            streamWriter.Write(line);
            streamWriter.Close();
        }
    }
}
