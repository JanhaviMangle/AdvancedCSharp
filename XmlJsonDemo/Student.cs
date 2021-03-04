using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonDemo
{
    class Student
    {
        int rollno;
        string name;
        List<string> cources;

        public global::System.Int32 Rollno { get => rollno; set => rollno = value; }
        public global::System.String Name { get => name; set => name = value; }
        public List<global::System.String> Cources { get => cources; set => cources = value; }
    }
}
