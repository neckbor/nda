using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameRes
{
    public class Game
    {
        Target _plane;
        Rocket _rocket;
        Image planeImg;
        Image rocketImg;

        bool _stopThread = false;

        public delegate void EventHandlerImage(Image img);
        public event EventHandlerImage FieldHasChanged;

        public Game(Image target, Image rocket)
        {
            planeImg = target;
            rocketImg = rocket;

        }

        public void Start()
        {
            Thread threadPlane = new Thread(new ThreadStart(ThreadDraw));
            threadPlane.IsBackground = true;
            threadPlane.Start();
        }

        //object locker = new object();

        private void ThreadDraw()
        {
            _plane = new Target(planeImg);
            _rocket = new Rocket(rocketImg);

            bool hit = false;

            while (!_stopThread)
            {
                _plane.Move();

               _rocket.Move();

                //hit = TestHitPlane(_plane, _rocket);

                if (_plane.Away || hit)
                    _plane = new Target(planeImg);

                if (_rocket.Away || hit)
                   _rocket = new Rocket(rocketImg);

                if(!_stopThread)
                    FieldHasChanged(_plane.Model);

                Thread.Sleep(20);
            }

        }

        public Target GetPlane()
        {
            return _plane;
        }

        
        public void UpdateField(Graphics g)
        {
            g.DrawImage(_plane.Model, _plane.X, _plane.Y);
            g.DrawImage(_rocket.Model, _rocket.X, _rocket.Y);

            Drawing.DrawPanel(g);
        }

        public void StopThread()
        {
            _stopThread = true;
        }

        public void RocketUp()
        {
            if (_rocket == null)
                return;
            _rocket.Y -= 3;
        }

        public void RocketDown()
        {
            if (_rocket == null)
                return;
            _rocket.Y += 3;
        }

        public void RocketLeft()
        {
            if (_rocket == null)
                return;
            _rocket.X -= 3;
        }

        public void RocketRight()
        {
            if (_rocket == null)
                return;
            _rocket.X += 3;
        }
    }
}
