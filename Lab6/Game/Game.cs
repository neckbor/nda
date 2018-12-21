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

        public Game(Image target)
        {
            planeImg = target;

            _plane = new Target(planeImg);

            _plane.MoveComplited += UpdatePlane;
        }

        public void Start()
        {
            Thread threadPlane = new Thread(new ThreadStart(ThreadDraw));
            threadPlane.IsBackground = true;
            threadPlane.Start();
        }

        private void ThreadDraw()
        {
            _plane = new Target(planeImg);
            _rocket = new Rocket();

            bool hit = false;

            while (!_stopThread)
            {
                _plane.Move();

                _rocket.Move();

                //hit = TestHitPlane(_plane, _rocket);

                if(_plane.Away || hit)
                    _plane = new Target(planeImg);

                if(_rocket.Away || hit)
                    _rocket = new Rocket();

                Thread.Sleep(2);
            }
        }

        public Graphics UpdateField(Graphics g)
        {
            g.DrawImage(_plane.Model, _plane.X, _plane.Y);

            g = Drawing.DrawPanel(g);
            return g;
        }

        public void UpdatePlane()
        {
            
            _plane = new Target(planeImg);

            _plane.MoveComplited += UpdatePlane;
            Start();
        }

        public void StopThread()
        {
            _stopThread = true;
        }
    }
}
