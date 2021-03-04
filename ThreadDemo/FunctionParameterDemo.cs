using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class FunctionParameterDemo
    {

        public void DisplayNumbers(object Max)
        {
            int Number = Convert.ToInt32(Max);
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
           
        }

        static void Main()
        {
            FunctionParameterDemo fp = new FunctionParameterDemo();
            ParameterizedThreadStart pts = new ParameterizedThreadStart(fp.DisplayNumbers);
            Thread t1 = new Thread(pts);
            int max = 10;
               t1.Start(max);
              //   t1.Start("Hii");

            Console.ReadKey();
        }
    }
}