using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogic;
using System.Threading;

namespace ConsoleTest
{
    class Program
    {
        static Conveyor conveyor1 = new Conveyor();
        static Conveyor conveyor2 = new Conveyor();
        static Conveyor conveyor3 = new Conveyor();

        static Engineer engineer = new Engineer();
        static Loader loader = new Loader();

        static void Main(string[] args)
        {
            conveyor1.ConveyorWasBroken += engineer.Fix;
            conveyor2.ConveyorWasBroken += engineer.Fix;
            conveyor1.MaterialIsEnded += loader.Load;
            conveyor2.MaterialIsEnded += loader.Load;

            conveyor3.ConveyorWasBroken += engineer.Fix;
            conveyor3.MaterialIsEnded += loader.Load;

            Thread thread1 = new Thread(new ThreadStart(conveyor1.Run));
            thread1.Start();
            Thread thread2 = new Thread(new ThreadStart(conveyor2.Run));
            thread2.Start();
           // Thread thread3 = new Thread(new ThreadStart(conveyor3.Run));
           // thread3.Start();


            Console.WriteLine("Главный поток всё");
            Console.ReadKey();
        }
    }
}
