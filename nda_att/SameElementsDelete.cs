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
        private string result;
        public SameElementsDelete(string input)
        {
            _data = StrToArray<int>(input);
        }

        private void RefreshData()
        { }

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
                IfSame(i);
        }

        //Удаление одинаковых элементов с данным
        private void IfSame(int i)
        {
            for (int ind = i + 1; ind < _data.Length; ind++)
                if (_data[ind] == _data[i])
                    Remove(ind);
        }

        private void Remove(int ind)
        {
            for (; ind < _data.Length; ind++)
                if (ind != _data.Length - 1)
                    _data[ind] = _data[ind + 1];
                else
                    _data[ind] = ;
        }

    }

}
