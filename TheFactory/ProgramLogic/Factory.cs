using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class Factory
    {
        List<Thread> _threadsConv;
        public List<Conveyor> Conveyors;
        public Loader Loader;
        public Engineer Engineer;

        private bool _isWorking = false;
        public Factory()
        {
            Conveyors = new List<Conveyor>();
            Conveyor conveyor = new Conveyor();
            conveyor.Y = 100;

            Conveyors.Add(conveyor);

            _threadsConv = new List<Thread>();

            Thread thread = new Thread(new ThreadStart(conveyor.Run));

            _threadsConv.Add(thread);

            conveyor.ConveyorWasBroken += SendEngineer;
            conveyor.MaterialIsEnded += SendLoader;

            Loader = new Loader();
            Engineer = new Engineer();
        }

        public void AddConveyor()
        {
            if (Conveyors.Count <= 4)
            {
                Conveyor conveyor = new Conveyor();

                Conveyors.Add(conveyor);

                conveyor.Y = Conveyors.Count * 150;

                conveyor.ConveyorWasBroken += SendEngineer;
                conveyor.MaterialIsEnded += SendLoader;

                Thread threadConv = new Thread(new ThreadStart(conveyor.Run));
                _threadsConv.Add(threadConv);

                if (_isWorking)
                    threadConv.Start();
            }
        }

        public void Start()
        {
            if (Conveyors.Count == 0)
                return;

            _isWorking = true;

            foreach (Thread conveyor in _threadsConv)
            {
                conveyor.Start();
            }
        }

        public void Break()
        {
            foreach (Thread thread in _threadsConv)
            {
                thread.Abort();
            }
        }

        public void SendLoader(Conveyor conv)
        {
            Loader.Load(conv);
        }

        public void SendEngineer(Conveyor conv)
        {
            Engineer.Fix(conv);
        }
    }
}
