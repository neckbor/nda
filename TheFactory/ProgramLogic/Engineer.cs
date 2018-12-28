using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProgramLogic
{
    public class Engineer : IEngineering
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Moving { get; set; }

        object blocker = new object();
        public void Fix(Conveyor conveyor)
        {
            lock(blocker)
            {
                X = 800;
                Y = conveyor.Y - 60;

                Moving = true;

                while(X >= 150)
                {
                    X--;
                    Thread.Sleep(6);
                }

                Thread.Sleep(2000);

                while(X <= 600)
                {
                    X++;
                    Thread.Sleep(6);
                }

                X = 800;
                Moving = false;
                conveyor.IsWorking = true;
            }
        }
    }
}
