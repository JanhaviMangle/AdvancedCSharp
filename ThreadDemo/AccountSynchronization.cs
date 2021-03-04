using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Bank
    {
        decimal totalBalance = 50000;
        decimal amount;

        public Bank(decimal amount)
        {
            this.amount = amount;
        }
        public void WithDraw()
        {
            lock (this)
            {
                if (amount > totalBalance)
                {
                    Console.WriteLine("Insufficient Amount.");
                }

                totalBalance -= amount;
                Console.WriteLine("Total Balance {0}", totalBalance);
            }
        }
    }
    class AccountSynchronization
    {
        static void Main()
        {
            Bank b1 = new Bank(5000);

            Bank b2 = new Bank(10000);

            Thread t1 = new Thread(new ThreadStart(b1.WithDraw));
            Thread t2 = new Thread(new ThreadStart(b2.WithDraw));

            t1.Start();
            t2.Start();
            Console.ReadKey();


        }
    }
}
