using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO
{
    class SerializationDemo
    {
        static void Main()
        {
            UserDetails u1 = new UserDetails(101, "Veera", "Akola");
            Console.WriteLine("Before Serialization object contains");
            u1.GetDetails();

            string fpath = @"c:\Demo\Serialize.txt";

            //Delete file if exists
            if(File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            //open a file
            Stream s = File.Open(fpath, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            //Serialize the objects into its binary format
            bf.Serialize(s, u1);

            s.Close();
            Console.WriteLine("Serialization successful");
            Console.ReadKey();
        }
    }
}
