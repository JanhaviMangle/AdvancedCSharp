using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    public class Player
    {
        public void play()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is Running");
        }
    }
    class PriorityDemo
    {
        static void Main()
        {
            Player p = new Player();

            Thread t1 = new Thread(new ThreadStart(p.play));
            Thread t2 = new Thread(new ThreadStart(p.play));
            Thread t3 = new Thread(new ThreadStart(p.play));

            t1.Name = "Player1";
            t2.Name = "Player2";
            t3.Name = "Player3";

            t3.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t1.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadKey();
        }
    }
}

