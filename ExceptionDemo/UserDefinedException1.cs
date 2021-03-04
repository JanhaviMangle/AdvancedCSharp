using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class OddNumberException :Exception
    {
        //Override the message properly
        public override string Message { get { return "Divisor cannot be odd number"; } }
    }
    class UserDefinedException1
    {
        static void Main()
        {
            int x, y, z;
            Console.WriteLine("ENTER TWO INTEGER NUMBERS:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            try
            {
                if(y % 2 > 0)
                {
                    throw new OddNumberException();
                }
                z = x / y;
                Console.WriteLine(z);
            }
            catch(OddNumberException e)
            {
                Console.WriteLine(e);
            }

           
        }
    }
}
