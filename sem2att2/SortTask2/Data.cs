using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTask2
{
    class Measurement
    {
        private double _x;
        private double _value;

        public Measurement (double xIn, double valueIn)
        {
            _x = xIn;
            _value = valueIn;
        }

        public double GetX()
        {
            return _x;
        }

        public double GetValue()
        {
            return _value;
        }
    }

    class Data
    {
        private double _a;
        private Measurement[] _data;

        public Data(double a, double[] x)
        {
            _a = a;

            _data = new Measurement[x.Length];

            for(int i = 0; i < x.Length; i++)
            {
                _data[i] = new Measurement(x[i], SetValue(x[i]));
            }
        }

        private double SetValue(double x)          //вычисление показаний прибора
        {
            return _a * Math.Sin(_a * x) * Math.Cos(2 * x / _a);
        }

        public double GetA()
        {
            return _a;
        }

        public Measurement[] GetData()
        {
            return _data;
        }

        public int GetDataCount()
        {
            return _data.Length;
        }
    }
}
