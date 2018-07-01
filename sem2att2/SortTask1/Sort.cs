using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTask1
{
    class Sort
    {
        private static int _compare = 0,
                           _change = 0;
        public static int[] SimpleMergeSort(int[] mas)
        {
            if (mas.Length == 1)
                return mas;

            int[] arr1, arr2;

            if (mas.Length % 2 == 0)
            {
                arr1 = new int[mas.Length / 2];
                arr2 = new int[mas.Length / 2];
            }
            else
            {
                arr1 = new int[mas.Length / 2 + 1];
                arr2 = new int[mas.Length / 2];
            }

            int a = 0, b = 0;

            for (int i = 0; i < mas.Length; i++)
                if (a < arr1.Length)
                    arr1[a++] = mas[i];
                else
                    arr2[b++] = mas[i];

            arr1 = SimpleMergeSort(arr1);
            arr2 = SimpleMergeSort(arr2);

            mas = Merge(arr1, arr2);

            return mas;
        }

        private static int[] Merge(int[] arr1, int[] arr2)
        {
            int[] mas = new int[arr1.Length + arr2.Length];

            int a = 0,
                b = 0;

            for (int i = 0; i < mas.Length; i++)
                if (a < arr1.Length && b < arr2.Length)
                {
                    _compare++;
                    if (arr1[a] < arr2[b])
                    {
                        mas[i] = arr1[a++];
                        _change++;
                    }
                    else
                    {
                        mas[i] = arr2[b++];
                        _change++;
                    }
                }
                else
                    if (a < arr1.Length)
                    {
                        mas[i] = arr1[a++];
                        _change++;
                    }
                    else
                    {
                        mas[i] = arr2[b++];
                        _change++;
                    }

            return mas;
        }

        public static int[] NatureMergeSort(int[] mas)
        {
            List<int> series1 = new List<int>(),
                      series2 = new List<int>(),
                      buf = new List<int>();
            int count = 0;

            for (int i = 0; i < mas.Length - 1; i++)
            {
                buf.Add(mas[i]);
                if (mas[i] > mas[i + 1])
                {
                    _compare++;
                    if (count % 2 == 0)
                    {
                        for (int j = 0; j < buf.Count; j++)
                            series1.Add(buf[j]);

                        buf.Clear();
                    }
                    else
                    {
                        for (int j = 0; j < buf.Count; j++)
                            series2.Add(buf[j]);

                        buf.Clear();
                    }

                    count++;
                }
            }

            mas = Merge(series1, series2);
            if (count != mas.Length)
                NatureMergeSort(mas);

            return mas;
        }

        private static int[] Merge(List<int> series1, List<int> series2)
        {
            int[] mas = new int[series1.Count + series2.Count];

            int a = 0,
                b = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (a < series1.Count && b < series2.Count)
                {
                    _compare++;
                    if (series1[a] < series2[b])
                    {
                        mas[i] = series1[a++];
                        _change++;
                    }
                    else
                    {
                        mas[i] = series2[b++];
                        _change++;
                    }
                }
                else
                    if (a < series1.Count)
                    {
                        mas[i] = series1[a++];
                        _change++;
                    }
                    else
                    {
                        mas[i] = series2[b++];
                        _change++;
                    }
            }

            return mas;
        }

        public static int[] ShakerSort(int[] mas)
        {
            int ind = 0,
                buffer = 0;
            int left = 0;                       //Левая граница
            int right = mas.Length - 1;       //Правая граница
            while (left < right)
            {
                for (int i = left; i < right; i++)      //Слева направо
                {
                    _compare++;
                    if (mas[i + 1] > mas[i]) //Math.Abs(_data[i].GetValue() - _data[i + 1].GetValue()) > 0
                    {
                        buffer = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = buffer;
                        ind = i;
                        _change++;
                    }
                }
                right = ind;        //Сохраним последнюю перестановку как границу

                if (left >= right) break;       //Если границы сошлись выходим

                for (int i = right; i > left; i--)      //Справа налево
                {
                    _compare++;
                    if (mas[i] < mas[i - 1])
                    {
                        buffer = mas[i];
                        mas[i] = mas[i - 1];
                        mas[i - 1] = buffer;
                        ind = i;
                        _change++;
                    }
                }
                left = ind;     //Сохраним последнюю перестановку как границу
            }

            return mas;
        }

        public static int GetChangeCount()
        {
            int x = _change;
            _change = 0;
            return x;
        }

        public static int GetCompareCount()
        {
            int x = _compare;
            _compare = 0;
            return x;
        }
    }
}
