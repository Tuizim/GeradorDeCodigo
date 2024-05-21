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
            #region Paths
            string xmlbasePath = @"C:\Users\artur.trombim\Documents\Outros\ArquivosTemporarios (testes)\XmlCODEGENERATOR";
            string xmlFilePath = xmlbasePath + @"\Web.config" ;
            string xmlFilePathBase = xmlbasePath + @"\Web.Piloto.SAO.config";
            #endregion

            #region Tratamento
            if (!(File.Exists(xmlFilePath) || !File.Exists(xmlFilePathBase)))
            {
                Console.WriteLine($@"PATH incorreto: {xmlFilePath}");
                Console.WriteLine($@"PATH incorreto: {xmlFilePathBase}");
                return;
            }
            #endregion

            #region Declaração de variaveis
            
            XElement xmlDoc = XElement.Load(xmlFilePathBase);


            Dictionary<string,string> dicElemento = new Dictionary<string, string>();
            Dictionary<string, string> dicAtributo = new Dictionary<string, string>();

            #endregion

            #region Dicionario

            XmlFinder.AddDicByElement(xmlDoc: xmlDoc, mudar: "value", elemento: "name", dicionario: dicElemento, filtros: new List<string> { "applicationSettings", "setting" });

            XmlFinder.AddDicByAtribut(xmlDoc: xmlDoc, mudar: "value", atributo: "key", dicionario: dicAtributo, filtros: new List<string> { "appSettings", "add" });

            XmlFinder.AddDicByAtribut(xmlDoc: xmlDoc, mudar: "connectionString", atributo: "name", dicionario: dicAtributo, filtros: new List<string> { "connectionStrings", "add" });

            XmlFinder.AddDicByAtribut(xmlDoc: xmlDoc, mudar: "address", atributo: "contract", dicionario: dicAtributo, filtros: new List<string> { "client", "endpoint" });

            // Salvarei em uma lista de dicionarios para facilitar a passagem como parametro.
            List<Dictionary<string, string>> dicList = new List<Dictionary<string, string>> {};
            dicList.Add(dicElemento);
            dicList.Add(dicAtributo);

            XmlFinder.ChangeXmlByElement(dicList, xmlFilePath);
            #endregion

        }
    }
}
