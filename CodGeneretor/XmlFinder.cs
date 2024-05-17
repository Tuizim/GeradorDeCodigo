using System;
using System.IO;
using System.Xml.Linq;

namespace CodGeneretor
{
    class XmlFinder
    {
        #region METODOS DE BUSCA

        /// <summary>
        /// Metodo para pegar ATRIBUTO HTTP especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void FindAtributoHttpXml(XElement xmlDoc, string decendete, string atributo)
        {
            foreach (XElement setting in xmlDoc.Descendants(decendete))
            {
                XAttribute nome = setting.Attribute(atributo);
                if (nome != null)
                {
                    if (nome.Value.StartsWith("http"))
                    {
                        Console.WriteLine(nome.Value); // Era assim
                        nome.Value = "Mudei";
                        Console.WriteLine(nome.Value);
                    }

                }
            }
        }

        /// <summary>
        /// Metodo para pegar ELEMENTO HTTP especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void FindElementoHttpXml(XElement xmlDoc, string decendete, string elemento)
        {
            foreach (XElement setting in xmlDoc.Descendants(decendete))
            {
                XElement nome = setting.Element(elemento);
                if (nome != null)
                {
                    if (nome.Value.StartsWith("http"))
                    {
                        Console.WriteLine(nome.Value); // Era assim
                        nome.Value = "Mudei";
                        Console.WriteLine(nome.Value);
                    }

                }
            }
        }

        /// <summary>
        /// Metodo para pegar ELEMENTO especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void FindElementoXml(XElement xmlDoc, string decendete, string elemento)
        {
            foreach (XElement setting in xmlDoc.Descendants(decendete))
            {
                XElement nome = setting.Element(elemento);
                if (nome != null)
                {
                    Console.WriteLine(nome.Value);
                }
            }
        }

        /// <summary>
        /// Metodo para pegar ATRIBUTO HTTP especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void FindAtributoXml(XElement xmlDoc, string decendete, string atributo)
        {
            foreach (XElement setting in xmlDoc.Descendants(decendete))
            {
                XAttribute nome = setting.Attribute(atributo); //Não tem como fazer alteração direta, mensagem diz ser por causa da falta de comparação de ver se é Vazio
                if (nome != null)
                {
                    Console.WriteLine(nome.Value + "\n\n"); //Era só isso
                    nome.Value = "Mudei"; //Caso der errado temos o replace: https://learn.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement.replaceattributes?view=net-8.0
                    Console.WriteLine(nome.Value + "\n\n");
                    Console.WriteLine(nome + "\n\n");
                }
            }
        }
        #endregion
    }
}
