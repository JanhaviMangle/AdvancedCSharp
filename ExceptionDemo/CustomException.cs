using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class UserDefinedException:Exception
    {
       public static void validate(int a)
        {
            throw new InvalidAgeException("Sorry !! Age must be greater than 18");
        }
    }

    [Serializable]
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string msg) : base(msg)
        {

        }
    }

    class CustomException
    {
        static void Main()
        {
            int age;
            Console.WriteLine("Enter ur Age:");
            age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (age < 18)
                {
                    UserDefinedException.validate(age);
                }
                else
                {
                    Console.WriteLine("Your age is:" + age);
                }
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
