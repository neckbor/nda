﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Rocket
    {
        //public Point Location { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Distance { get; private set; }

        public Rocket()
        {
            Distance = 0;
        }

        public void Move()
        {
            Distance++;
        }

    }
}
