using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    public class MyThread
    {
        public void Thread1()
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);

            }
        }
    }
    class JoinDemo
    {
        static void Main()
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            
           //It causes all the calling threads to wait until the current thread
          // (joined thread) is terminated or completes its task.


            t2.Start();
            t3.Start();

            Console.ReadKey();
        }
    }
}
