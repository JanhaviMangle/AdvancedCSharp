using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ThreadDemo
{
    class ReadXml
    {
        static void Main(string[] args)
        {
            //create XMLDocument object
            XmlDocument xmlDoc = new XmlDocument();

            //returns url of main directory which contains "/bin/Debug"
            var url = System.IO.Path.GetDirectoryName(
    System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            //correction in path to point it in Root directory
            var mainpath = url.Replace("\\bin\\Debug", "") + "\\book.xml";
            //load xml file
            xmlDoc.Load(mainpath);

            //save all nodes in XMLnodelist
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");

            //loop through each node and save it value in NodeStr
            var NodeStr = "";

            foreach (XmlNode node in nodeList)
            {
                NodeStr = NodeStr + "\nAuthor " + node.SelectSingleNode("author").InnerText;
                NodeStr = NodeStr + "\nTitle " + node.SelectSingleNode("title").InnerText;
                NodeStr = NodeStr + "\nGenre " + node.SelectSingleNode("genre").InnerText;
                NodeStr = NodeStr + "\nPrice " + node.SelectSingleNode("price").InnerText;
                NodeStr = NodeStr + "\nDescription -" + node.SelectSingleNode("description").InnerText;


            }
            //print all Authors details
            Console.WriteLine(NodeStr);
            Console.ReadKey();
        }
    }
}
