using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class FileStreamDemo1
    {
        static void Main(string[] args)
        {
            string fpath = @"c:\\Demo\\Test.txt";

            // Delete file if exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }

            // Create the file
            using (FileStream fs = File.Create(fpath))
            {
                AddTexttoFile(fs, "Hello");
                AddTexttoFile(fs, "\r\nWelcome to C#");
                AddTexttoFile(fs, "\r\nFileStream Example");
            }
        }

        private static void AddTexttoFile(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        
    }
}
