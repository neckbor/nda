using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._13
{
    class Multiplicity
    {
        //Построение множества У
        public static int[] Ybuild (int[] x1, int[] x2, int[] x3)
        {
            int maxLength;

            if (x1.Length >= x2.Length)
                if (x1.Length >= x3.Length)
                    maxLength = x1.Length;
                else
                    maxLength = x3.Length;
            else
                if (x2.Length >= x3.Length)
                    maxLength = x2.Length;
                else
                    maxLength = x3.Length;

            int[] y = new int[maxLength];
            int x1Elem,
                x2Elem,
                x3Elem;

            for (int i = 0; i < maxLength; i++)
            {
                if (i >= x1.Length)
                    x1Elem = 0;
                else
                    x1Elem = x1[i];

                if (i >= x2.Length)
                    x2Elem = 0;
                else
                    x2Elem = x2[i];

                if (i >= x3.Length)
                    x3Elem = 0;
                else
                    x3Elem = x3[i];

                y[i] = (x1Elem + x2Elem) * (x2Elem + x3Elem) * (x1Elem + x3Elem);
            }

            return y;
        }

        //Рассчитывание мощности У1
        public static string GetnY1(int[] y)
        {
            int count = 0;

            for (int i = 0; i < y.Length; i++)
                if (y[i] % 4 == 0)
                    count++;

            return count.ToString();
        }

        // Функция конвертирует строку в массив элементов T
        // (при невозможности конвертации происходит ошибка)
        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        // Функция конвертирует строку в значение T
        // (при невозможности конвертации происходит ошибка)
        private static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        //Печать массива
        public static string PrintData(int[] y)
        {
            string result = "";

            for (int i = 0; i < y.Length; i++)
                if (i != y.Length - 1)
                    result += y[i].ToString() + ", ";
                else
                    result += y[i].ToString();

            return result;
        }

    }
}
