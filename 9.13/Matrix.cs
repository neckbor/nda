using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._13
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

        //проход по массиву спиралью
        public bool IsSpiral()
        {
            double val = _data[0, 0],
                   nextval = _data[0, 1];

            int direction = 0,
                circles = 0,
                maxCircles = _data.GetLength(0) > _data.GetLength(1) ? _data.GetLength(1) / 2 : _data.GetLength(0) / 2;

            int r = circles,
                c = circles;

            while (val <= nextval && circles != maxCircles)
            {
                if (direction == 0) //вправо
                    if (c != _data.GetLength(1) - 1 - circles)
                    {
                        val = _data[r, c];
                        nextval = _data[r, c + 1];
                        c++;
                    }
                    else
                    {
                        direction++;
                        r = circles;
                        c = _data.GetLength(1) - 1 - circles;
                    }

                if (direction == 1)//вниз
                    if (r != _data.GetLength(0) - 1 - circles)
                    {
                        val = _data[r, c];
                        nextval = _data[r + 1, c];
                        r++;
                    }
                    else
                    {
                        direction++;
                        r = _data.GetLength(0) - 1 - circles;
                        c = _data.GetLength(1) - 1 - circles;
                    }
                if (direction == 2)//влево
                    if (c != circles)
                    {
                        val = _data[r, c];
                        nextval = _data[r, c - 1];
                        c--;
                    }
                    else
                    {
                        direction++;
                        r = _data.GetLength(0) - 1 - circles;
                        c = _data.GetLength(1) - 1 - circles;
                        circles++;
                    }
                if (direction == 3)//вверх
                    if (r != circles)
                    {
                        val = _data[r, c];
                        nextval = _data[r - 1, c];
                        r--;
                    }
                    else
                    {
                        direction = 0;
                        r = circles;
                        c = circles;
                    }
            }
            if (circles == maxCircles)
                return true;
            else
                return false;
        }

        //проход по массиву змейкой
        public bool IsSnake()
        {
            for (int c = 0; c < _data.GetLength(1); c++)
                if (c % 2 == 0)
                {
                    for (int r = _data.GetLength(0) - 1; r > 0; r--)
                        if (_data[r, c] > _data[r - 1, c])
                            return false;
                }
                else
                    for (int r = 0; r < _data.GetLength(0) - 1; r++)
                        if (_data[r, c] > _data[r + 1, c])
                            return false;

            return true;
        }
    }
}
