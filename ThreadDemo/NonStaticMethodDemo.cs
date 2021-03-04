using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Employee
    {
        public void display()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class NonStaticMethodDemo
    {
        static void Main()
        {
            Employee e1 = new Employee();

            Thread t1 = new Thread(new ThreadStart(e1.display));
            Thread t2 = new Thread(new ThreadStart(e1.display));

            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
    }
}
