using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationAndFiles
{
    public class XmlSerializer<T> : IFiles<T>
    {
        public bool Save(string path, T data)
        {
            bool retorno = false;

            try
            {
                if (path != null && (Directory.Exists(path)))
                {
                    using (XmlTextWriter auxWriter = new XmlTextWriter(path, Encoding.UTF8))
                    {
                        XmlSerializer newXml = new XmlSerializer(typeof(T));
                        newXml.Serialize(auxWriter, data);
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception($"ERROR AL GUARDAR EN LA RUTA: {path}.");
            }
            return retorno;
        }

        public bool Read(string path, out T data)
        {
            bool retorno = false;
            data = default;

            try
            {
                if (path != null)
                {
                    using (XmlTextReader aux = new XmlTextReader(path))
                    {
                        XmlSerializer newXml = new XmlSerializer(typeof(T));
                        data = (T)newXml.Deserialize(aux);
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception($"ERROR AL LEER DESDE LA RUTA: {path}.");
            }
            return retorno;
        }
    }
}
