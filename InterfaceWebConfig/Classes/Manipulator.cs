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
        /// Método para mudar ELEMENTO especifico no XML
        /// ( contentDoc , originalDoc , filtros ,  mudar , atributo )
        /// </summary>
        public static void ElementoXml(XElement contentDoc, XElement originalDoc, List<string> filtros, string mudar, string atributo)
        {
            IEnumerable<XElement> newTags = GetDecendants(contentDoc, filtros);
            IEnumerable<XElement> originalTags = GetDecendants(originalDoc, filtros);

            foreach (XElement item in newTags)
            {
                XAttribute key = item.Attribute(atributo);
                XElement value = item.Element(mudar);

                if (value == null || key == null)
                {
                    Console.WriteLine("Erro no value ou key");
                    return;
                }

                XElement originalKey = originalTags.FirstOrDefault(e => (string)e.Attribute(atributo) == key.Value);

                if (originalKey == null)
                {
                    Console.WriteLine($"Elemento com atributo {atributo} = {key.Value} não encontrado.");
                    return;
                }

                XElement originalValue = originalKey.Element(mudar);
                originalValue.Value = value.Value;
            }
        }

        /// <summary>
        /// Método para mudar ATRIBUTO especifico no XML
        /// ( contentDoc , originalDoc , filtros ,  mudar , atributo )
        /// </summary>
        public static void AtributoXml(XElement contentDoc, XElement originalDoc, List<string> filtros, string mudar, string atributo)
        {
            IEnumerable<XElement> newTags = GetDecendants(contentDoc, filtros);
            IEnumerable<XElement> originalTags = GetDecendants(originalDoc, filtros);

            foreach (XElement item in newTags)
            {
                XAttribute key = item.Attribute(atributo);
                XAttribute value = item.Attribute(mudar);

                if (value == null || key == null)
                {
                    Console.WriteLine("Erro no value ou key");
                    return;
                }

                XElement originalKey = originalTags.FirstOrDefault(e => (string)e.Attribute(atributo) == key.Value);

                if (key.Value == "XMLLogService.IXmlLog")
                {
                    XAttribute keyName = item.Attribute("name");
                    originalKey = originalTags.FirstOrDefault(e => (string)e.Attribute(atributo) == key.Value && (string)e.Attribute("name") == keyName.Value);
                }

                if (originalKey == null)
                {
                    Console.WriteLine($"Elemento com atributo {atributo} = {key.Value} não encontrado.");
                    return;
                }

                XAttribute originalValue = originalKey.Attribute(mudar);
                originalValue.Value = value.Value;
            }
        }

        /// <summary>
        /// Método para trocar ELEMENTO SERVER especifico no XML
        /// ( contentDoc , originalDoc , filtros ,  mudar , atributo )
        /// </summary>
        public static void ServerXml(XElement contentDoc, XElement originalDoc, List<string> filtros, string mudar, string atributo)
        {
            IEnumerable<XElement> newTags = GetDecendants(contentDoc, filtros);
            IEnumerable<XElement> originalTags = GetDecendants(originalDoc, filtros);

            bool existSqlServerOnNewTag = newTags.Any(tag => tag.Attribute(atributo).Value == "sqlserver");
            bool existSqlServerOnOriginalTag = originalTags.Any(tag => tag.Attribute(atributo).Value == "sqlserver");

            if (!existSqlServerOnNewTag && existSqlServerOnOriginalTag)
            {
                XElement elemento = originalTags.Single(tag => tag.Attribute(atributo).Value == "sqlserver");

                Console.WriteLine($"elemento: {elemento}");
                XElement elementoValue = GetServers(elemento, new List<string> { mudar, "server" });

                XElement novoElemento = XElement.Parse("<server host=\"DBPROD01\"/>"); //Não fazer replace diretamente porque o < e > se tornam elementos html &lt; e &gt;
                elementoValue.ReplaceWith(novoElemento);
            }

            foreach (XElement item in newTags)
            {
                XAttribute key = item.Attribute(atributo);
                XElement value = GetServers(item, new List<string> { mudar, "server" });

                if (value == null || key == null)
                {
                    Console.WriteLine("Erro no value ou key");
                    return;
                }

                XElement originalKey = originalTags.FirstOrDefault(e => (string)e.Attribute(atributo) == key.Value);

                if (originalKey == null)
                {
                    Console.WriteLine($"Elemento com atributo {atributo} = {key.Value} não encontrado.");
                    return;
                }

                XElement originalValue = GetServers(originalKey, new List<string> { mudar, "server" });

                originalValue.ReplaceWith(value);
            }
        }

        /// <summary>
        /// Método para trocar ATRIBUTO de uma TAG especifica no XML DIRETAMENTE
        /// Deve ser usado para trocar valores de tags/caminhos que aparecem uma única vez no documento
        /// ( contentDoc , originalDoc , filtros ,  mudar )
        /// </summary>
        public static void DirectChange(XElement contentDoc, XElement originalDoc, List<string> filtros, string mudar)
        {
            IEnumerable<XElement> newTags = GetDecendants(contentDoc, filtros);
            IEnumerable<XElement> originalTags = GetDecendants(originalDoc, filtros);

            if (newTags.Count() == 1 && originalTags.Count() == 1)
            {
                XAttribute newValue = newTags.First().Attribute(mudar);
                XAttribute originalValue = originalTags.First().Attribute(mudar);

                originalValue.Value = newValue.Value;
            }
        }

        /// <summary>
        /// Método para retornar ELEMENTO XML já FILTRADO
        /// ( doc , filtros )
        /// </summary>
        public static IEnumerable<XElement> GetDecendants(XElement doc, List<string> filtros)
        {
            IEnumerable<XElement> tags = doc.Descendants(filtros[0]);

            foreach (string filtro in filtros.Skip(1))
            {
                tags = tags.Descendants(filtro);
            }

            return tags;
        }

        /// <summary>
        /// Método para retornar Elemento Servers ou Server
        /// ( Key , filtros )
        /// </summary>
        public static XElement GetServers(XElement originalKey, List<string> filtros)
        {
            XElement originalValue = null;

            foreach (string filtro in filtros)
            {
                originalValue = originalKey.Element(filtro);
                if (originalValue != null)
                    break;
            }

            return originalValue;
        }
        #endregion
    }
}
