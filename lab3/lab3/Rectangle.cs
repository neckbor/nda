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
            Point p3;

            double length = GetLength();

            _length = (int)Math.Round(length, MidpointRounding.AwayFromZero);

            for (int i = 1; i <= _n; i++)
            {
                p2 = GetVertwex(i);
                p3 = GetVertwex(i + 1);

                if (_length != 0)
                    DrawArc(p1, i, p3);
                else
                    DrawLine(p1, p2);

                p1 = p2;
                p2 = p3;
            }

            return _bitmap;
        }
 
        //Вычисляет длину, которую надо отнимать от каждой вершины для скругления
        private double GetLength()
        {
            return _rCircle / Math.Tan(_angle / 2);
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

        //высчитывает координаты центра дуги
        private Point GetArcCenter(int i)
        {
            Point p = new Point();

            double x = _centr.X + (_rRec - _rCircle / Math.Sin(_angle / 2)) * Math.Cos(2 * Math.PI * i / _n);
            double y = _centr.Y + (_rRec - _rCircle / Math.Sin(_angle / 2)) * Math.Sin(2 * Math.PI * i / _n);

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
                Swap(ref start, ref end);
            
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

        //Отнимает от вершины расстояние _length в сторону другой вершины
        private void GetNewPoint(ref Point p1, Point p2)
        {
            if (_length == 0)
                return;

            bool flagI = false;
            if (Math.Abs(p1.X - p2.X) < Math.Abs(p1.Y - p2.Y))
            {
                Interpolate(ref p1);
                Interpolate(ref p2);
                flagI = true;
            }

            float a = (float)(p2.Y - p1.Y) / (float)(p2.X - p1.X);
            double y = p1.Y;

            if (p1.X < p2.X)
                for (int x = p1.X; x <= p2.X; x++)
                {
                    int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                    double vec = Math.Sqrt(Math.Pow(x - p1.X, 2) + Math.Pow(y - p1.Y, 2));

                    if ((int)Math.Round(vec, MidpointRounding.AwayFromZero) == _length)
                    {
                        if (flagI)
                            p1 = new Point(yy, x);
                        else
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
                        if (flagI)
                            p1 = new Point(yy, x);
                        else
                            p1 = new Point(x, yy);
                        return;
                    }

                    y -= a;
                }

            throw new Exception("Ошибка при высчитывании новой точки");
        }

        //отрисовка дуги
        private void DrawArc(Point pLeft, int i, Point pRight)
        {
            Point p1 = GetVertwex(i);
            Point p2 = GetVertwex(i);

            GetNewPoint(ref p1, pLeft);
            GetNewPoint(ref pLeft, p1);
            DrawLine(p1, pLeft);

            GetNewPoint(ref p2, pRight);
            GetNewPoint(ref pRight, p2);
            DrawLine(p2, pRight);

            Point centr = GetArcCenter(i);

            if (p1.X > p2.X)
                Swap(ref p1, ref p2);

            if (p1.X < p2.X)
            {
                if (centr.Y <= p1.Y)
                {
                    if (centr.Y <= p2.Y)
                        for (int x = p1.X; x <= p2.X; x++)
                        {
                            double y = Math.Sqrt(Math.Pow(_rCircle, 2) - Math.Pow(x - centr.X, 2)) + centr.Y;
                            int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                            _bitmap.SetPixel(x, yy, Color.Black);
                        }
                    else
                    {
                        for (int x = p1.X; x <= p2.X; x++)
                        {
                            double y = -Math.Sqrt(Math.Pow(_rCircle, 2) - Math.Pow(x - centr.X, 2)) + centr.Y;
                            int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                            _bitmap.SetPixel(x, yy, Color.Black);
                        }
                    }
                }
                else
                {
                    if (centr.Y <= p2.Y)
                    {
                        for (int x = p1.X; x >= centr.X - _rCircle; x--)
                        {
                            double y = -Math.Sqrt(Math.Pow(_rCircle, 2) - Math.Pow(x - centr.X, 2)) + centr.Y;
                            int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                            _bitmap.SetPixel(x, yy, Color.Black);
                        }

                        for(int x = p2.X; x >= centr.X - _rCircle; x--)
                        {
                            double y = Math.Sqrt(Math.Pow(_rCircle, 2) - Math.Pow(x - centr.X, 2)) + centr.Y;
                            int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                            _bitmap.SetPixel(x, yy, Color.Black);
                        }
                    }
                    else
                        for(int x = p1.X; x <= p2.X; x++)
                        {
                            double y = -Math.Sqrt(Math.Pow(_rCircle, 2) - Math.Pow(x - centr.X, 2)) + centr.Y;
                            int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                            _bitmap.SetPixel(x, yy, Color.Black);
                        }
                }
            }
            else if (p1.X == p2.X)
            {
                if (p1.X > centr.X)
                    for (int x = p1.X; x <= centr.X + _rCircle; x++)
                    {
                        double y = -Math.Sqrt(Math.Pow(_rCircle, 2) - Math.Pow(x - centr.X, 2)) + centr.Y;
                        int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                        _bitmap.SetPixel(x, yy, Color.Black);

                        y = Math.Sqrt(Math.Pow(_rCircle, 2) - Math.Pow(x - centr.X, 2)) + centr.Y;
                        yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                        _bitmap.SetPixel(x, yy, Color.Black);
                    }
                else
                    for (int x = p1.X; x >= centr.X - _rCircle; x--)
                    {
                        double y = -Math.Sqrt(Math.Pow(_rCircle, 2) - Math.Pow(x - centr.X, 2)) + centr.Y;
                        int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                        _bitmap.SetPixel(x, yy, Color.Black);

                        y = Math.Sqrt(Math.Pow(_rCircle, 2) - Math.Pow(x - centr.X, 2)) + centr.Y;
                        yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                        _bitmap.SetPixel(x, yy, Color.Black);
                    }

                return;
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
        private void Interpolate(ref Point p)
        {
            int a = p.X;
            p.X = p.Y;
            p.Y = a;
        }
    }
}
