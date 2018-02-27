using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nda_att
{
    public class SameElementsDelete
    {
        private int[] _data;
        public SameElementsDelete(string input)
        {
            _data = StrToArray<int>(input);
        }

        // Функция конвертирует строку в массив элементов T
        // (при невозможности конвертации происходит ошибка)
        private T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        // Функция конвертирует строку в значение T
        // (при невозможности конвертации происходит ошибка)
        private T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        //Перебор массива по элементам и вызов удаляющуго метода
        public void SameItemsDetect()
        {
            for (int i = 0; i < _data.Length; i++)
                while(IfSame(i))
                { }
        }

        //Удаление одинаковых элементов с данным
        private bool IfSame(int i)
        {
            for (int ind = i + 1; ind < _data.Length; ind++)
                if (_data[ind] == _data[i])
                {
                    Remove(ind);
                    return true;
                }
            return false;
        }

        private void Remove(int ind)
        {
            for (; ind < _data.Length - 1; ind++)
                    _data[ind] = _data[ind + 1];

            _data = RefreshData();
        }
        //Перезапись массива
        public int[] RefreshData()
        {
            int[] newData = new int[_data.Length - 1];

            for (int i = 0; i < newData.Length; i++)
                newData[i] = _data[i];

            //SameItemsDetect();

            return newData;
        }
        //Печать массива
        public string PrintData()
        {
            string result = "";

            for (int i = 0; i < _data.Length; i++)
                if (i != _data.Length - 1)
                    result += _data[i].ToString() + ", ";
                else
                    result += _data[i].ToString();

            return result;
        }

    }

}
