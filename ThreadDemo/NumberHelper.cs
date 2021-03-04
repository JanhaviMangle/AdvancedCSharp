using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class NumberHelper
    {
        int _Number;

        public NumberHelper(int number)
        {
            _Number = number;
        }
        public void DisplayNumber()
        {
            for(int i=1; i <= _Number;i++)
            {
                Console.WriteLine("Value:" + i);
            }
        }
    }
}
