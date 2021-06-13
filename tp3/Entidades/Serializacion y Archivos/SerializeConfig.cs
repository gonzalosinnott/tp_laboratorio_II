using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Entidades.Interfaces;

namespace Entidades

{
    public class SerializeConfig<T> : ISerializacion<T>
    {
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