using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonDemo
{
    class GenerateJson
    {
        static void Main()
        {
            Student s1 = new Student();

            s1.Rollno = 101;
            s1.Name = "John";
            s1.Cources = new List<string> { "Ajax", "c sharp", "java" };

            string jsonResult = JsonConvert.SerializeObject(s1);

            string path = @"c:\\Demo\\student.json";

            using (var t = new StreamWriter(path, true))
            {
                t.WriteLine(jsonResult.ToString());
                t.Close();
            }
            Console.ReadKey();
        }
    }
}
