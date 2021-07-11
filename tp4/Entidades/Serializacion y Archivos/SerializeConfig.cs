using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Entidades.Interfaces;
using iTextSharp.text.pdf;


namespace Entidades

{
    public class SerializeConfig<T> : ISerializacion<T>
    {

        /// <summary>
        /// Guarda en un archivo XML la lista de piezas en el PATH pasado como parametro
        /// </summary>
        public bool XmlCreation<T>(string filePath, List<T> list)
        {
            if (filePath != null)
            {
                SerializeConfig<List<T>> auxList = new SerializeConfig<List<T>>();
                try
                {
                    auxList.Serialize(list, filePath);
                }
                catch
                {
                    throw new Exception($"Error al querer gaurdar el achivo en la ruta: {filePath}.");
                }
                return true;
            }
            return false;

        }

        public bool PdfCreation(string info, string filePath)
        {
            if (info != null)
            {
                try
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();
                    doc.Add(new iTextSharp.text.Paragraph($"Documento creado en fecha: {DateTime.Now}"));
                    doc.Add(new iTextSharp.text.Paragraph(info));
                    doc.Close();
                }
                catch (Exception)
                {
                    throw new Exception($"Error al querer gaurdar el achivo en la ruta: {filePath}.");
                }
                return true;
            }
            return false;
        }
        /// <summary>
        /// Guarda los datos que le pasamos como paramentro en el PATH indicado como parametro
        /// </summary>        
        /// <returns></returns>
        public bool Serialize(T data, string path)
        {
            bool retorno = false;

            if(path != null)
            {
                using (XmlTextWriter auxWriter = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                    nuevoXml.Serialize(auxWriter, data);
                    retorno = true;
                }
            }

            return retorno;
        }
        /// <summary>
        /// Convierte los datos alojados en el xml que pasamos como parametro a la lista pasada como parametro.
        /// </summary>        
        public bool Deserialize(string path, out T data)
        {
            bool retorno = false;

            data = default;
            
            if(path != null)
            {
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    XmlSerializer aux = new XmlSerializer(typeof(T));
                    data = (T)aux.Deserialize(reader);
                    retorno = true;
                }
            }
            return retorno;  
        }
    }
}