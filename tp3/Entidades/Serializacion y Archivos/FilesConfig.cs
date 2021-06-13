using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml;
using System.Xml.Xsl;
using iText;



namespace Entidades
{
    public class FilesConfig
    {
        public static void MakeHTML(string loadPath, string savePath, string stylePath)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(stylePath);

            xslt.Transform(loadPath, savePath);            
        }

        public static void MakePDF(string loadPath, string savePath)
        {

           
        }


    }
}
