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

        public Game(Image target)
        {
            planeImg = target;

            _plane = new Target(planeImg);

            _plane.MoveComplited += UpdatePlane;
        }

        public void Start()
        {
            Thread threadPlane = new Thread(new ThreadStart(_plane.Move));
            threadPlane.IsBackground = true;
            threadPlane.Start();
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
    }
}
