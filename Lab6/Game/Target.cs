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
                    X = 0;
                    break;
                case 1:
                    _path = Path.TO_TOP;
                    X = 1400;
                    break;
                case 2:
                    _path = Path.TO_BOTTOM;
                    X = 0;
                    break;
                case 3:
                    _path = Path.HILL;
                    X = 1400;
                    break;
            }
            
            
        }

        public void Move()
        {

        }
    }
}
