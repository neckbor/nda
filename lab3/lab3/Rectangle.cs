using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Rectangle
    {
        private int _n;
        private double _angle;
        private double _rCircle;
        private int _rRec = 150;
        private Point _centr = new Point(200, 190);
        private Bitmap _bitmap;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="n">Количество углов</param>
        /// <param name="r">Радиус скругления</param>
        /// <param name="bitmap">Битмап, куда рисовать</param>
        public Rectangle(int n, double r,  Bitmap bitmap)
        {
            _n = n;
            _rCircle = r;
            _bitmap = bitmap;
            _angle = CalculateAngle();
        }

        /// <summary>
        /// Высчитывает величину угла многоугольника
        /// </summary>
        /// <returns>double</returns>
        private double CalculateAngle()
        {
            double angle = (_n - 2) * 180 / _n;

            return (Math.PI * angle) / 180;
        }

        /// <summary>
        /// Рисует многоугольник
        /// </summary>
        /// <returns>Битмап с многоугольником</returns>
        public Bitmap Draw()
        {
            Point p1 = GetVertwex(0);
            Point p2;

            for (int i = 1; i <= _n; i++)
            {
                p2 = GetVertwex(i);

                DrawLine(p1, p2);

                p1 = p2;
            }

            return _bitmap;
        }

        /// <summary>
        /// Высчитывает вершнину
        /// </summary>
        /// <param name="i">Номер вершины</param>
        /// <returns>Возвращает вершину</returns>
        private Point GetVertwex(int i)
        {
            Point p = new Point();

            double x = _centr.X + _rRec * Math.Cos(2 * Math.PI * i / _n);
            double y = _centr.Y + _rRec * Math.Sin(2 * Math.PI * i / _n);

            p.X = (int)Math.Round(x, MidpointRounding.AwayFromZero);
            p.Y = (int)Math.Round(y, MidpointRounding.AwayFromZero);

            return p;
        }

        /// <summary>
        /// Отрисовать линию
        /// </summary>
        /// <param name="start">Начальная точка</param>
        /// <param name="end">Конечная точка</param>
        private void DrawLine(Point start, Point end)
        {
            bool flag = false;
            if (Math.Abs(start.X - end.X) < Math.Abs(start.Y - end.Y))
            {
                Interpolate(ref start, ref end);
                flag = true;
            }

            if (start.X > end.X)
            {
                Swap(ref start, ref end);
            }

            float a = (float)(end.Y - start.Y) / (float)(end.X - start.X);
            double y = start.Y;

            for (int x = start.X; x <= end.X; x++)
            {
                int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                if (flag)
                    _bitmap.SetPixel(yy, x, Color.Black);
                else
                    _bitmap.SetPixel(x, yy, Color.Black);

                y += a;
            }
        }

        //Поменять начало и конец
        private void Swap(ref Point start, ref Point end)
        {
            int a = start.X;
            start.X = end.X;
            end.X = a;

            a = start.Y;
            start.Y = end.Y;
            end.Y = a;
        }

        //Поменять х и у
        private void Interpolate(ref Point start, ref Point end)
        {
            int a = start.X;
            start.X = start.Y;
            start.Y = a;

            a = end.X;
            end.X = end.Y;
            end.Y = a;
        }

    }
}
