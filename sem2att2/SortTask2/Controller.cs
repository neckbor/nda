using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortTask2
{
    class Controller
    {
        /*
         * 1 2 3 4 5 6 7 8 9
         * */
        private ShakerSort _sort;
        private Data _data;

        public Controller(string inputA, string inputX)
        {
           Double dd = Double.Parse(inputA);
           // _data = new Data(dd, StrToArray<double>(inputX));

            _data = new Data(dd, StrToArray(inputX));
            _sort = new ShakerSort(_data.GetData());
        }

        // Функция конвертирует строку в значение T
        // (при невозможности конвертации происходит ошибка)
        private double StrToValue(string str)
        {
            return Double.Parse(str);//(T)Convert.ChangeType(str, typeof(T));
        }

        // Функция конвертирует строку в массив элементов T
        // (при невозможности конвертации происходит ошибка)
        private double[] StrToArray(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue(s)
            );
        }

        // Функция конвертирует массив элементов T в строку
        // (вторым параметром можно указать разделитель, по умолчанию ", ")
        private string ArrayToStr<T>(List<double> arr, string separator = ", ")
        {
            return arr == null ? "null" : string.Join(separator, arr);
        }

        public void SetGridView(DataGridView dgv)
        {
            dgv.ReadOnly = true;                        //запрет правки
            dgv.ColumnCount = 3;                        //колво столбцов
            dgv.RowCount = _data.GetDataCount();        //колво строк
            dgv.ColumnHeadersVisible = true;            //видимость заголовков столбцов
            dgv.Columns[0].Width = 30;
            dgv.Columns[1].Width = 30;
            dgv.Columns[2].Width = 227;
            dgv.Columns[0].HeaderText = "a";            
            dgv.Columns[1].HeaderText = "x";            //подписи
            dgv.Columns[2].HeaderText = "result";
            dgv.RowHeadersWidth = 20;
            dgv.ScrollBars = ScrollBars.Vertical;

            Measurement[] sortedData = _sort.GetSortedData();

            for (int r = 0; r < dgv.RowCount; r++)
            {
                dgv[0, r].Value = _data.GetA();
                dgv[1, r].Value = sortedData[r].GetX();
                dgv[2, r].Value = sortedData[r].GetValue();
            }
        }
    }
}
