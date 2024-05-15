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
        public static void FindAtributoHttpXml(string filePath, string decendete, string atributo)
        {

            if (File.Exists(filePath))
            {
                XElement xmlDoc = XElement.Load(filePath);
                foreach (XElement setting in xmlDoc.Descendants(decendete))
                {
                    XAttribute nome = setting.Attribute(atributo);
                    if (nome != null)
                    {
                        if (nome.Value.StartsWith("http"))
                        {
                            Console.WriteLine(nome.Value);
                        }

                    }
                }
            }
            else { Console.WriteLine($@"PATH incorreto: {filePath}"); }
        }

        /// <summary>
        /// Metodo para pegar ELEMENTO HTTP especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void FindElementoHttpXml(string filePath, string decendete, string elemento)
        {

            if (File.Exists(filePath))
            {
                XElement xmlDoc = XElement.Load(filePath);
                foreach (XElement setting in xmlDoc.Descendants(decendete))
                {
                    XElement nome = setting.Element(elemento);
                    if (nome != null)
                    {
                        if (nome.Value.StartsWith("http"))
                        {
                            Console.WriteLine(nome.Value);
                        }

                    }
                }
            }
            else { Console.WriteLine($@"PATH incorreto: {filePath}"); }
        }

        /// <summary>
        /// Metodo para pegar ELEMENTO especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void FindElementoXml(string filePath, string decendete, string elemento)
        {

            if (File.Exists(filePath))
            {
                XElement xmlDoc = XElement.Load(filePath);
                foreach (XElement setting in xmlDoc.Descendants(decendete))
                {
                    XElement nome = setting.Element(elemento);
                    if (nome != null)
                    {
                        Console.WriteLine(nome.Value);
                    }
                }
            }
            else { Console.WriteLine($@"PATH incorreto: {filePath}"); }
        }

        /// <summary>
        /// Metodo para pegar ATRIBUTO HTTP especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void FindAtributoXml(string filePath, string decendete, string atributo)
        {

            if (File.Exists(filePath))
            {
                XElement xmlDoc = XElement.Load(filePath);
                foreach (XElement setting in xmlDoc.Descendants(decendete))
                {
                    XAttribute nome = setting.Attribute(atributo);
                    if (nome != null)
                    {
                        Console.WriteLine(nome.Value);
                    }
                }
            }
            else { Console.WriteLine($@"PATH incorreto: {filePath}"); }
        }
        #endregion
    }
}
