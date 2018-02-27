using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._13
{
    class Matrix
    {
        private double[,] _data;

        public Matrix(double[,] mtx)
        {
            _data = mtx;
        }

        public bool IsDataSquare()
        {
            if (_data.GetLength(0) == _data.GetLength(1))
                return true;
            return false;
        }
        //Возвращает сумму главной диагонали
        public string GetMainSum()
        {
            double sum = 0;

            for (int i = 0; i < _data.GetLength(0); i++)
                sum += _data[i, i];

            return sum.ToString();
        }
        //Возвращает сумму побочной диагонали
        public string GetDownSum()
        {
            double sum = 0;

            for (int r = 0; r < _data.GetLength(0); r++)
                for (int c = 0; c < _data.GetLength(1); c++)
                    if(r == _data.GetLength(1) - 1 - c)
                        sum += _data[r, c];

            return sum.ToString();
        }
    }
}
