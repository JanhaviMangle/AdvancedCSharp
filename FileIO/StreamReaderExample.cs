using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class StreamReaderExample
    {
        static void Main(string[] args)
        {

            FileStream f = new FileStream("c:\\Demo\\b.txt", FileMode.OpenOrCreate);

            Console.WriteLine("File opened");

            //declared stream reader
            StreamReader sr = new StreamReader(f);
            Console.WriteLine("Reading data from the file");

            string line = sr.ReadLine();

            Console.WriteLine("The data from the file is : " + line);

            //closing stream writer
            sr.Close();
            f.Close();

            Console.WriteLine("File Stream closed");

            Console.ReadLine();
        }
    }
}
