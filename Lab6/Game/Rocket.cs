using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRes
{
    class Rocket
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Distance { get; set; }
        public bool Away { get; set; }

        public Image Model;

        public Rocket(Image model)
        {
            Model = model;

            Distance = 0;
            X = 600;
            Y = 700;
        }

        public void Move()
        {
            Distance++;
            Y -= 3;

            Away = (Y < -100 || X > 1500 || X < -500);
        }

    }
}
