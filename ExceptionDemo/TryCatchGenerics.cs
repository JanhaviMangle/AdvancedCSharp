using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class TryCatchGenerics
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }

            catch (Exception ex)


            {


                Console.WriteLine(ex.Message);


                Console.WriteLine(ex.Source);


                Console.WriteLine(ex.HelpLink);


            }
            // catch
            // {
            //     Console.WriteLine("error occured....");
            // }
            Console.ReadKey();
        }
    }
}
