using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace CodGeneretor
{
    class Manipulator
    {
        #region METODOS DE BUSCA

        /// <summary>
        /// Metodo para mudar ELEMENTO especifico no XML
        /// ( contentDoc , originalDoc , filtros ,  mudar , atributo )
        /// </summary>
        public static void ElementoXml(XElement contentDoc, XElement originalDoc, List<string> filtros, string mudar, string atributo)
        {
            IEnumerable<XElement> tags = contentDoc.Descendants(filtros[0]);
            IEnumerable<XElement> tags2 = originalDoc.Descendants(filtros[0]);

            foreach (string filtro in filtros.Skip(1))
            {
                tags = tags.Descendants(filtro);
                tags2 = tags2.Descendants(filtro);
            }

            foreach (XElement item in tags)
            {
                XAttribute key = item.Attribute(atributo);
                XElement value = item.Element(mudar);

                if (value == null || key == null)
                {
                    Console.WriteLine("Erro no value ou key");
                    return;
                }

                XElement key2 = tags2.FirstOrDefault(e => (string)e.Attribute(atributo) == key.Value);

                if (key2 == null)
                {
                    Console.WriteLine($"Elemento com atributo {atributo} = {key.Value} não encontrado.");
                }
                else
                {
                    XElement value2 = key2.Element(mudar);
                    value2.Value = value.Value;
                }
            }
        }

        /// <summary>
        /// Metodo para mudar ATRIBUTO especifico no XML
        /// ( contentDoc , originalDoc , filtros ,  mudar , atributo )
        /// </summary>
        public static void AtributoXml(XElement contentDoc, XElement originalDoc, List<string> filtros, string mudar, string atributo)
        {
            IEnumerable<XElement> tags = contentDoc.Descendants(filtros[0]);
            IEnumerable<XElement> tags2 = originalDoc.Descendants(filtros[0]);

            foreach (var filtro in filtros.Skip(1))
            {
                tags = tags.Descendants(filtro);
                tags2 = tags2.Descendants(filtro);
            }

            foreach (XElement item in tags)
            {
                XAttribute key = item.Attribute(atributo);
                XAttribute value = item.Attribute(mudar);

                if (value == null || key == null)
                {
                    Console.WriteLine("Erro no value ou key");
                    return;
                }

                XElement key2 = tags2.FirstOrDefault(e => (string)e.Attribute(atributo) == key.Value);

                if (key.Value == "XMLLogService.IXmlLog")
                {
                    XAttribute keyName = item.Attribute("name");
                    key2 = tags2.FirstOrDefault(e => (string)e.Attribute(atributo) == key.Value && (string)e.Attribute("name") == keyName.Value);
                }

                if (key2 == null)
                {
                    Console.WriteLine($"Elemento com atributo {atributo} = {key.Value} não encontrado.");
                }
                else
                {
                    XAttribute value2 = key2.Attribute(mudar);
                    value2.Value = value.Value;
                }
            }
        }

        /// <summary>
        /// Metodo para trocar ELEMENTO SERVER especifico no XML
        /// ( contentDoc , originalDoc , filtros ,  mudar , atributo )
        /// </summary>
        public static void ServerXml(XElement contentDoc, XElement originalDoc, List<string> filtros, string mudar, string atributo)
        {
            IEnumerable<XElement> tags = contentDoc.Descendants(filtros[0]);
            IEnumerable<XElement> tags2 = originalDoc.Descendants(filtros[0]);

            foreach (string filtro in filtros.Skip(1))
            {
                tags = tags.Descendants(filtro);
                tags2 = tags2.Descendants(filtro);
            }

            foreach (XElement item in tags)
            {
                XAttribute key = item.Attribute(atributo);
                XElement value = item.Element(mudar);

                if (value == null)
                {
                    Console.WriteLine("Erro: Servers não deve existir");
                    Console.WriteLine($"Key: {key}");
                    value = item.Element("server");
                }

                if (value == null || key == null)
                {
                    Console.WriteLine("Erro no value ou key");
                    return;
                }

                XElement key2 = tags2.FirstOrDefault(e => (string)e.Attribute(atributo) == key.Value);

                if (key2 == null)
                {
                    Console.WriteLine($"Elemento com atributo {atributo} = {key.Value} não encontrado.");
                }
                else
                {
                    XElement value2 = key2.Element(mudar);

                    if (value2 == null)
                    {
                        value2 = key2.Element("server");
                    }
                    value2.ReplaceWith(value);
                }
            }
        }
        #endregion
    }
}
