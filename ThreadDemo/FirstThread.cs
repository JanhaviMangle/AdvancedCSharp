using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class FirstThread
    {
        static void Main(string[] args)
        {
            //Create child thread
            Thread t1 = new Thread(new ThreadStart(PrintInfo));
            //start newly created thread
            t1.Start();
            Console.WriteLine("Main Thread completed");
            Console.ReadLine();
        }
        static void PrintInfo()
        {
            for(int i=1;i<=4;i++)
            {
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("child thread completed");
        }
    }
}
