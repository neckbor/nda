using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProgramLogic
{
    public class Conveyor
    {
        public int Material { get; set; }
        public bool IsWorking { get; set; }
        public int Y { get; set; }

        Loader loader = new Loader();
        Engineer engineer = new Engineer();

        public event Action<Conveyor> ConveyorWasBroken;
        public event Action<Conveyor> MaterialIsEnded;

        public Conveyor()
        {
            Material = 20;
            IsWorking = true;
        }

        public void Run()
        {
            Random rnd = new Random();
            while (IsWorking)
            {
                if (rnd.Next(1, 101) == 4)
                {
                    IsWorking = false;
                    ConveyorWasBroken(this);
                }

                Material--;

                if (Material == 0)
                {
                    MaterialIsEnded(this);
                    //Material += rnd.Next(20, 40);
                }

                Thread.Sleep(500);
            }
        }
    }
}
