using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class CheckedDemo
    {
        static void Main(string[] args)
        {
            checked
            {
                int a = int.MaxValue; //store max value of integer data type
                Console.WriteLine(a + 2);
                
            }
            Console.ReadKey();
        }
    }
}
