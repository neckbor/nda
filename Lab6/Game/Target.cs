using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Target
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Distance { get; }

        private bool _side; //true = слева, false = справа

        private Path _path;

        private enum Path
        {
            STRAIGHT,
            TO_TOP,
            TO_BOTTOM,
            HILL
        };
          


        public Target()
        {
            Random rnd = new Random();
            int path = rnd.Next(0, 3);

            //определяю по какой траектроии пойдёт цель и с какой стороны
            switch (path)
            {
                case 0:
                    _path = Path.STRAIGHT;
                    _side = rnd.Next(0, 30) >= 15;
                    break;
                case 1:
                    _path = Path.TO_TOP;
                    _side = rnd.Next(0, 30) >= 15;
                    break;
                case 2:
                    _path = Path.TO_BOTTOM;
                    _side = rnd.Next(0, 30) >= 15;
                    break;
                case 3:
                    _path = Path.HILL;
                    _side = rnd.Next(0, 30) >= 15;
                    break;
            }

            if (_side)
                X = 0;
            else
                X = 1400;
        }

        public void Move()
        {
            switch(_path)
            {
                case Path.STRAIGHT:
                    MoveStraight();
                    break;

                case Path.TO_TOP:
                    MoveToTop();
                    break;

                case Path.TO_BOTTOM:
                    MoveToBottom();
                    break;

                case Path.HILL:
                    MoveHill();
                    break;
            }
        }

        private void MoveStraight()
        {
            if(_side)
                for(; X < 1500; X += 2)
                {
                    Y += a;
                }
        }

        private void MoveToTop()
        { }

        private void MoveToBottom()
        {
    
        }

        private void MoveHill()
        { }
    }
}
