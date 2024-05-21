using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Xml;

namespace CodGeneretor
{
    class XmlFinder
    {
        #region Metodo de busca

        public static void ChangeXmlByElement(List<Dictionary<string, string>> dicList, string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);

            foreach (var dic in dicList)
            {
                foreach (var dicItem in dic)
                {
                    string wantedKey = dicItem.Key;
                    string wantedValue = dicItem.Value;
                    //Até aqui ta indo, o problema agora é
                    //preciso encontrar o item que o key corresponde
                    //apos isso alterar o local onde aparece http.


                    XmlNodeList nodes = xmlDoc.SelectNodes($"//*[text()='{wantedKey}']");

                    if (nodes != null && nodes.Count > 0)
                    {
                        foreach (XmlNode node in nodes)
                        {
                            if (node.InnerText == wantedKey)
                            {
                                node.InnerText = wantedValue;
                            }
                        }
                    }
                }
            }

            xmlDoc.Save(xmlPath);
            Console.WriteLine(xmlDoc.OuterXml); // Output the modified XML
        }
        #endregion

        #region Criação de Dicionarios

        /// <summary>
        /// Metodo para pegar ELEMENTO especifico no XML e adicionar 
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void AddDicByElement(XElement xmlDoc, List<string> filtros, string mudar, string elemento, Dictionary<string, string> dicionario)
        {
            IEnumerable<XElement> tags = xmlDoc.Descendants(filtros[0]);
            
            //Já que inicamos com o primeiro elemento vamos pular ele, caso existir.
            foreach (string filtro in filtros.Skip(1))
            {
                tags = tags.Descendants(filtro);
            }

            foreach (XElement setting in tags)
            {
                XAttribute key = setting.Attribute(elemento);
                XElement value = setting.Element(mudar);
                
                if (value == null || key == null)
                {
                    Console.WriteLine("Erro no value ou key");
                    return;
                }
                //Console.WriteLine($"Nome: {value.Value}, key: {key.Value}");
                dicionario.Add(key.Value, value.Value);
            }
        }

        /// <summary>
        /// Metodo para pegar ATRIBUTO HTTP especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void AddDicByAtribut(XElement xmlDoc, List<string> filtros, string mudar, string atributo, Dictionary<string, string> dicionario)
        {
            IEnumerable<XElement> tags = xmlDoc.Descendants(filtros[0]);

            //Já que inicamos com o primeiro elemento vamos pular ele, caso existir.
            foreach (var filtro in filtros.Skip(1))
            {
                Console.WriteLine(filtro);
                tags = tags.Descendants(filtro);
            }

            foreach (XElement setting in tags)
            {
                XAttribute id = setting.Attribute(atributo);
                XAttribute nome = setting.Attribute(mudar);

                if (!(nome != null || id != null))
                {
                    Console.WriteLine("Erro no nome ou id");
                }
                //Console.WriteLine($"Nome: {nome.Value}, id: {id.Value}");
                dicionario.Add(id.Value, nome.Value);
            }
        }
        #endregion
    }
}
