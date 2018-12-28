using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProgramLogic
{
    public class Loader
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsFull { get; set; }
        public bool Moving { get; set; }

        object blocker = new object();
        public void Load(Conveyor conveyor)
        {
            lock (blocker)
            {
                X = 800;

                Y = conveyor.Y - 60;

                Moving = true;
                IsFull = true;

                while(X >= 600)
                {
                    X--;
                    Thread.Sleep(2);
                }

                Random rnd = new Random();
                conveyor.Material += rnd.Next(15, 30);

                IsFull = false;
                Thread.Sleep(1500);

                while (X <= 900)
                {
                    X++;
                    Thread.Sleep(2);
                }

                Moving = false;        
            }
        }
    }
}
