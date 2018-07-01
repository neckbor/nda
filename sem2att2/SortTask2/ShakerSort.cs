using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTask2
{
    class ShakerSort
    {
        private Measurement[] _data;

        public ShakerSort(Measurement[] data)
        {
            _data = data;
        }

        public Measurement[] GetSortedData()
        {
            Sort();
            return _data;
        }

        private void Sort()
        {
            int ind = 0;
            Measurement buffer = new Measurement(0, 0);
            int left = 0;                       //Левая граница
            int right = _data.Length - 1;       //Правая граница
            while (left < right)
            {
                for (int i = left; i < right; i++)      //Слева направо
                {
                    if (_data[i].GetValue() > _data[i + 1].GetValue()) //Math.Abs(_data[i].GetValue() - _data[i + 1].GetValue()) > 0
                    {
                        buffer = _data[i];
                        _data[i] = _data[i + 1];
                        _data[i + 1] = buffer;
                        ind = i;
                    }
                }
                right = ind;        //Сохраним последнюю перестановку как границу

                if (left >= right) break;       //Если границы сошлись выходим

                for (int i = right; i > left; i--)      //Справа налево
                {
                    if (_data[i].GetValue() < _data[i - 1].GetValue())
                    {
                        buffer = _data[i];
                        _data[i] = _data[i - 1];
                        _data[i - 1] = buffer;
                        ind = i;
                    }
                }
                left = ind;     //Сохраним последнюю перестановку как границу
            }
        }
    }
}
