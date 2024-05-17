using System;
using System.IO;
using System.Xml.Linq;

namespace CodGeneretor
{
    class Program
    {
        static void Main(string[] args)
        {
            //string xmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Main.xml");
            string xmlFilePath = @"C:\Users\gabriel.bonil\Documents\WTX WebConfig\FilipeWebConfig - Copy.xml";
            Console.WriteLine("Path: ", xmlFilePath);

            if (!File.Exists(xmlFilePath))
            {
                Console.WriteLine($@"PATH incorreto: {xmlFilePath}");
            }
            else
            {
                XElement xmlDoc = XElement.Load(xmlFilePath);

                Console.WriteLine("\n\nFind Element HTTP Settings/value \n");
                XmlFinder.FindElementoHttpXml(xmlDoc, "setting", "value");

                Console.WriteLine("\n\nFind Attribute add/value \n");
                XmlFinder.FindAtributoHttpXml(xmlDoc, "add", "value");

                Console.WriteLine("\n\nFind Attribute add/connectionString \n");
                XmlFinder.FindAtributoXml(xmlDoc, "add", "connectionString");

                Console.WriteLine("\n\nFind Attribute endpoint/address \n");
                XmlFinder.FindAtributoHttpXml(xmlDoc, "endpoint", "address");

                xmlDoc.Save(xmlFilePath);
            }
        }
    }
}
