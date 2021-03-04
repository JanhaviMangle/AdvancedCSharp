using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class MainThreadDemo
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread; //access main thread
            //By Default the Thread does not have any name
            //if you want then you can provide the name explicitly
            t.Name = "Main Thread";
            
            Console.WriteLine("Current Executing Thread Name :" + t.Name);
            Console.WriteLine("Thread Id:{0}", t.ManagedThreadId);
            Console.WriteLine("Is Background Thread:{0}", t.IsBackground);
            Console.WriteLine("Thread Culture:{0}", t.CurrentCulture);
            Console.ReadKey();
        }
    }
}
