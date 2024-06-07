using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CodGeneretor
{
    class Generator
    {
        #region METODOS DE LISTAGEM DE PATH
        public static string[] List_ProjectWebConfig(string rootDirectory)
        {
            return Directory.GetFiles(rootDirectory, "Web.config", SearchOption.AllDirectories);
        }

        public static string[] List_FolderWebConfigs(string path)
        {
            return Directory.GetFiles(path, $"Web.*.config", SearchOption.AllDirectories);
        }

        #endregion

        #region METODOS PARA RETORNO DE NOMES DE ARQUIVOS
        public static List<string> GetName_Folder(string[] paths)
        {
            List<string> folderNames = new List<string> { };
            foreach (var dir in paths)
            {
                folderNames.Add(Path.GetDirectoryName(dir).Split('\\').Last());
            }
            return folderNames;
        }

        public static List<string> GetName_DocumentsInFolder(string[] folderPath)
        {
            List<string> docsName = new List<string> { };
            foreach (var doc in folderPath)
            {
                docsName.Add(Path.GetFileName(doc));
            }
            return docsName;
        }
        #endregion

        #region METODOS QUE TRATAM O WEBCONFIG
        public static void ChangeWebConfig(XElement originalDoc, XElement contentDoc)
        {
            Manipulator.AtributoXml(contentDoc: contentDoc, originalDoc: originalDoc, mudar: "value", atributo: "key",
                filtros: new List<string> { "activerecord", "add" });

            Manipulator.ElementoXml(contentDoc: contentDoc, originalDoc: originalDoc, mudar: "value", atributo: "name",
                filtros: new List<string> { "applicationSettings", "setting" });

            Manipulator.AtributoXml(contentDoc: contentDoc, originalDoc: originalDoc, mudar: "value", atributo: "key",
                filtros: new List<string> { "appSettings", "add" });

            Manipulator.AtributoXml(contentDoc: contentDoc, originalDoc: originalDoc, mudar: "connectionString", atributo: "name",
                filtros: new List<string> { "connectionStrings", "add" });

            Manipulator.AtributoXml(contentDoc: contentDoc, originalDoc: originalDoc, mudar: "address", atributo: "contract",
                filtros: new List<string> { "client", "endpoint" });

            Manipulator.ServerXml(contentDoc: contentDoc, originalDoc: originalDoc, mudar: "servers", atributo: "provider",
                filtros: new List<string> { "itravel.framework", "client" });
        }

        public static void OverrideWebconfigAndSave(string pathOriginalWebConfig, string pathWebConfigBase)
        {
            XElement contentDoc = XElement.Load(pathWebConfigBase);
            XElement originalDoc = XElement.Load(pathOriginalWebConfig);

            Generator.ChangeWebConfig(originalDoc: originalDoc, contentDoc: contentDoc);

            originalDoc.Save(pathOriginalWebConfig);
        }
        #endregion

    }
}
