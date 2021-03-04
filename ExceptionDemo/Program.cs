using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int a = 20;
                int b = 0;
                int c;
                Console.WriteLine("A VALUE = " + a);
                Console.WriteLine("B VALUE = " + b);
                c = a / b;
               
                Console.ReadKey();

            
             int d, e, f;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            d = int.Parse(Console.ReadLine()); 
            e = int.Parse(Console.ReadLine());
            if(b==0)
            {
                Console.WriteLine("The second number should be Non Zero");
            }
            else
            {
                f = d/ e;
                Console.WriteLine("c value=" + f);
            }


        }
    }
}

