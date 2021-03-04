using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class LifeCycleDemo
    {
        static void Main(string[] args)

        {

            // Create child thread
            Thread t1 = new Thread(new ThreadStart(PrintInfo));

            Console.WriteLine("Thread State: {0}", t1.ThreadState);

            // Start newly created thread
            t1.Start();

            Console.WriteLine("Thread State: {0}", t1.ThreadState);

            // Suspend thread
          //  t1.Suspend();

            Console.WriteLine("Thread State: {0}", t1.ThreadState);

            // Resume thread to running state
           // t1.Resume();

            Console.WriteLine("Thread State: {0}", t1.ThreadState);
            Console.ReadLine();
        }

        static void PrintInfo()
        {
            Console.WriteLine("Method Execution");
        }

    }
}
