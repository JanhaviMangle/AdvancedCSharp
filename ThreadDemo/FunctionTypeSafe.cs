using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class FunctionTypeSafe
    {
        //make the thread function type-safe in C#
        static void Main()
        {
            int max = 10;
            NumberHelper nh = new NumberHelper(max);

            Thread t1 = new Thread(new ThreadStart(nh.DisplayNumber));
            t1.Start();
            Console.Read();
        }
    }
}
