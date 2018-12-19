using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameRes
{
    class Target
    {
        public event Action MoveComplited;

        public Image Model;
        public int X { get; set; }
        public int Y { get; set; }
        public int Distance { get; }

        private bool _side; //true = слева, false = справа
        private Path _path;
        private double _a;
        private int _y0;
        private int _y1;

        private enum Path
        {
            STRAIGHT,
            TO_TOP,
            //TO_BOTTOM,
            //HILL
        };
          


        public Target(Image model)
        {
            Model = model;

            Random rnd = new Random();

            _y0 = rnd.Next(0, 530);
            _y1 = rnd.Next(0, 530);

            _side = rnd.Next(0, 2) == 1;

            ////int path = rnd.Next(0, 3);
            //int path = rnd.Next(0, 2);
            ////определяю по какой траектроии пойдёт цель и с какой стороны
            //switch (path)
            //{
            //    case 0:
            //        _path = Path.STRAIGHT;
            //        _side = rnd.Next(0, 30) >= 15;
            //        break;
            //    case 1:
            //        _path = Path.TO_TOP;
            //        _side = rnd.Next(0, 30) >= 15;
            //        break;
            //    //case 2:
            //    //    _path = Path.TO_BOTTOM;
            //    //    _side = rnd.Next(0, 30) >= 15;
            //    //    break;
            //    //case 3:
            //    //    _path = Path.HILL;
            //    //    _side = rnd.Next(0, 30) >= 15;
            //    //    break;
            //}

            if (_side)
            {
                X = 0;
                Model.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            else
                X = 1100;

            _a = (double)(_y1 - _y0) / 350;

            //_a = rnd.Next(-5, 5);
            //while (_a == 0)
            //    _a = rnd.Next(5, 5);
        }

        public void Move()
        {
            //switch(_path)
            //{
            //    case Path.STRAIGHT:
            //        MoveStraight();
            //        break;

            //    case Path.TO_TOP:
            //        MoveToTop();
            //        break;

            //    //case Path.TO_BOTTOM:
            //    //    MoveToBottom();
            //    //    break;

            //    //case Path.HILL:
            //    //    MoveHill();
            //    //    break;
            //}
            double yy = _y0;
            if(_side)
                for (; X < 1500; X++)
                {
                    yy += _a;
                    Y = (int)Math.Round(yy, MidpointRounding.AwayFromZero);
                    Thread.Sleep(15);
                }
            else
                for (; X > -50; X--)
                {
                    yy += _a;
                    Y = (int)Math.Round(yy, MidpointRounding.AwayFromZero);
                    Thread.Sleep(15);
                }

            MoveComplited();
        }

        //private void MoveStraight()
        //{
        //    if (_side)
        //        for (; X < 1500; X++)
        //        {
        //            Y += _a;
        //            Thread.Sleep(10);
        //        }
        //    else
        //        for (; X > -50; X--)
        //        {
        //            Y += _a;
        //            Thread.Sleep(10);
        //        }
        //}

        //private void MoveToTop()
        //{
        //    if (_side)
        //        for (; X < 1500; X++)
        //        {
        //            Y = _a * X * X;
        //            Thread.Sleep(10);
        //        }
        //    else
        //        for (; X > -50; X--)
        //        {
        //            Y = _a * X * X;
        //            Thread.Sleep(10);
        //        }
        //}

        private void MoveToBottom()
        {
    
        }

        private void MoveHill()
        { }
    }
}
