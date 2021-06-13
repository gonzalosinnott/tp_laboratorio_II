using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml;
using System.Xml.Xsl;



namespace Entidades
{
    public class FilesConfig
    {   
        /// <summary>
        /// Convierte el archivo xml pasado como parametro en un archivo HTML en la ubicacion pasada como parametro a partir
        /// del formato pasado como estilo.
        /// </summary>  
        public static void MakeHTML(string loadPath, string savePath, string stylePath)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(stylePath);

            xslt.Transform(loadPath, savePath);
        }

    }
}
