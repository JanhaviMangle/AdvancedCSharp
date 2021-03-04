using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO
{
    class DeSerializationDemo
    {
        static void Main()
        {
            string fpath = @"c:\Demo\Serialize.txt";

            //Open the file Serialize.txt
            Stream s = File.Open(fpath,FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            //deserialize object
            UserDetails ud = (UserDetails)bf.Deserialize(s);
            s.Close();

            Console.WriteLine();
            Console.WriteLine("After Deserialization object contains:");
            ud.GetDetails();
            Console.ReadKey();
        }
    }
}
