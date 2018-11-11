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
        private int _length;
        private int _rRec = 150;
        private Point _centr = new Point(200, 190);
        private Bitmap _bitmap;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="n">Количество углов</param>
        /// <param name="r">Радиус скругления</param>
        /// <param name="bitmap">Битмап, куда рисовать</param>
        public Rectangle(int n, double r, Bitmap bitmap)
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

            double length = CalculateLength(GetVertwex(0), GetVertwex(1));

            _length = (int)Math.Round(length, MidpointRounding.AwayFromZero);

            for (int i = 1; i <= _n; i++)
            {
                p2 = GetVertwex(i);

                //double d = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
                DrawLine(p1, p2);
                
                p1 = p2;
            }

            return _bitmap;
        }

        /// <summary>
        /// Оределяет точки, до которых рисовать прямую р1->р2
        /// От конца прямой рисует дугу и определяет точку, откуда рисовать прямую р2->р3
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2">Цетральная точка</param>
        /// <param name="p3"></param>
        private double CalculateLength(Point p1, Point p2)
        {
            Point centr = _centr;
            bool flag = false;

            if (Math.Abs(p2.X - centr.X) < Math.Abs(p2.Y - centr.Y))
            {
                Interpolate(ref p2);
                Interpolate(ref centr);
                flag = true;
            }

            if (p2.X > centr.X)
            {
                Swap(ref p2, ref centr);
            }

            float aC = (float)(p2.Y - centr.Y) / (float)(p2.X - centr.X);
            double yC = centr.Y;
            double length;
            //if (flag)
            //{
            //    Interpolate(ref centr);
            //    Interpolate(ref p2);
            //}

            for (int x = p2.X; x <= centr.X; x++)
            {
                int yy = (int)Math.Round(yC, MidpointRounding.AwayFromZero);

                //if (centr == _centr)
                //    if (flag)
                //        length = CalculateLengthFromMiddlePoint(yy, x, p2);
                //    else
                //        length = CalculateLengthFromMiddlePoint(x, yy, p2);
                //else
                //    if (flag)
                //        length = CalculateLengthFromMiddlePoint(yy, x, centr);
                //    else
                //        length = CalculateLengthFromMiddlePoint(x, yy, centr);

                if (centr == _centr)
                    length = CalculateLengthFromMiddlePoint(x, yy, p2);
                else
                    length = CalculateLengthFromMiddlePoint(x, yy, centr);

                if (length != -1)
                    return length;
                
                yC += aC;
            }

            return -1;
        }

        /// <summary>
        /// Находим точку, откуда пойдёт полуокружность и высчитывает расстояние, которое надо отступить по прямой
        /// </summary>
        private double CalculateLengthFromMiddlePoint(int x, int y, Point p)
        {
            double hip = Math.Sqrt(Math.Pow(x - p.X, 2) + Math.Pow(y - p.Y, 2));

            if (Math.Abs(Math.Sin(_angle / 2) - _rCircle / hip) < Math.Pow(10, -1))
                return Math.Sqrt(Math.Pow(hip, 2) - Math.Pow(_rCircle, 2));
            else
                return -1;
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
                Interpolate(ref start);
                Interpolate(ref end);
                flag = true;
            }

            if (start.X > end.X)
            {
                Swap(ref start, ref end);
            }

            float a = (float)(end.Y - start.Y) / (float)(end.X - start.X);
            double y = start.Y;

            GetNewPoint(a, ref start, end);
            GetNewPoint(a, ref end, start);

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

        private void DrawArc(Point p1, Point p2)
        {

        }

        //Отнимает от вершины расстояние _length в сторону другой вершины
        private void GetNewPoint(float a, ref Point p1, Point p2)
        {
            if (_length == -1)
                return;

            double y = p1.Y;

            if(p1.X < p2.X)
                for(int x = p1.X; x <= p2.X; x++)
                {
                    int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                    double vec = Math.Sqrt(Math.Pow(x - p1.X, 2) + Math.Pow(y - p1.Y, 2));

                    if ((int)Math.Round(vec, MidpointRounding.AwayFromZero) == _length)
                    {
                        p1 = new Point(x, yy);
                        return;
                    }

                    y += a;
                }
            else
                for (int x = p1.X; x >= p2.X; x--)
                {
                    int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                    double vec = Math.Sqrt(Math.Pow(x - p1.X, 2) + Math.Pow(y - p1.Y, 2));

                    if ((int)Math.Round(vec, MidpointRounding.AwayFromZero) == _length)
                    {
                        p1 = new Point(x, yy);
                        return;
                    }

                    y -= a;
                }

            throw new Exception("Ошибка при высчитывании новой точки");
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
        private void Interpolate(ref Point p)
        {
            int a = p.X;
            p.X = p.Y;
            p.Y = a;
        }
    }
}
