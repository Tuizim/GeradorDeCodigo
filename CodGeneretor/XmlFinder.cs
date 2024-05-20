using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace CodGeneretor
{
    class XmlFinder
    {
        #region METODOS DE BUSCA

        /// <summary>
        /// Metodo para pegar ELEMENTO especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void FindElementoXml(XElement xmlDoc, List<string> filtros, string mudar, string atributo, Dic<string, string> dicionario)
        {
            IEnumerable<XElement> tags = xmlDoc.Descendants(filtros[0]);
            
            //Já que inicamos com o primeiro elemento vamos pular ele, caso existir.
            foreach (string filtro in filtros.Skip(1))
            {
                Console.WriteLine(filtro);
                tags = tags.Descendants(filtro);
            }

            foreach (XElement setting in tags)
            {
                XAttribute key = setting.Attribute(atributo);
                XElement value = setting.Element(mudar);
                
                if (value == null || key == null)
                {
                    Console.WriteLine("Erro no value ou key");
                    return;
                }
                //Console.WriteLine($"Nome: {value.Value}, key: {key.Value}");
                dicionario.Set(key.Value, value.Value);
            }
        }

        /// <summary>
        /// Metodo para pegar ATRIBUTO HTTP especifico no XML
        /// ( FilePath , Decendente , Atributo  )
        /// </summary>
        public static void FindAtributoXml(XElement xmlDoc, List<string> filtros, string mudar, string atributo, Dic<string, string> dicionario)
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
                dicionario.Set(id.Value, nome.Value);
            }
        }
        #endregion
    }
}
