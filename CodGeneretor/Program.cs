using System;
using System.IO;
using System.Xml.Linq;

namespace CodGeneretor
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Main.xml");

            XmlFinder.FindAtributoHttpXml(xmlFilePath, "add", "value");
            XmlFinder.FindAtributoXml(xmlFilePath, "add", "connectionString");
            XmlFinder.FindElementoHttpXml(xmlFilePath, "setting", "value");
            XmlFinder.FindAtributoHttpXml(xmlFilePath, "endpoint", "address");

        }
    }
}
