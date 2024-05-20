using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace CodGeneretor
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlFilePath = @"C:\Users\gabriel.bonil\Documents\WTX WebConfig\FilipeWebConfig - Copy.xml";
            string xmlFilePath2 = @"C:\Users\gabriel.bonil\Documents\WTX WebConfig\MyWebConfig TEST - Copy.xml";

            if (!(File.Exists(xmlFilePath) || !File.Exists(xmlFilePath2)))
            {
                Console.WriteLine($@"PATH incorreto: {xmlFilePath}");
                Console.WriteLine($@"PATH incorreto: {xmlFilePath2}");
                return;
            }

            XElement xmlDoc = XElement.Load(xmlFilePath);
            XElement xmlDoc2 = XElement.Load(xmlFilePath2);

            Dic<string, string> dicElemento = new Dic<string, string>();
            Dic<string, string> dicAtributo = new Dic<string, string>();

            Console.WriteLine("\n\nFind Element applicationSettings settings value \n");

            XmlFinder.FindElementoXml(xmlDoc: xmlDoc, mudar: "value", atributo: "name", dicionario: dicElemento,
                filtros: new List<string> { "applicationSettings", "setting" });

            Console.WriteLine("\n\nFind Attribute appSettings add/value \n");
            XmlFinder.FindAtributoXml(xmlDoc: xmlDoc, mudar: "value", atributo: "key", dicionario: dicAtributo,
                filtros: new List<string> { "appSettings", "add" });

            Console.WriteLine("\n\nFind Attribute connectionStrings add connectionString \n");
            XmlFinder.FindAtributoXml(xmlDoc: xmlDoc, mudar: "connectionString", atributo: "name", dicionario: dicAtributo,
                filtros: new List<string> { "connectionStrings", "add" });

            Console.WriteLine("\n\nFind Attribute system.serviceModel endpoint address \n");
            XmlFinder.FindAtributoXml(xmlDoc: xmlDoc, mudar: "address", atributo: "contract", dicionario: dicAtributo,
                filtros: new List<string> { "client", "endpoint" });

            xmlDoc.Save(xmlFilePath);
        }
    }
}
