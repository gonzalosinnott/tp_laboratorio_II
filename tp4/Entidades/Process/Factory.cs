using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;


namespace Entidades
{
    public class Factory
    {
        DAO parts = new DAO();
        /// <summary>
        /// Atributos de la clase Factory
        /// </summary>
        protected List<Part> partsList;
        protected List<Guitar> guitarsList;
        /// <summary>
        /// COsntructores de la clase Factory
        /// </summary>
        public Factory()
        {
            partsList = new List<Part>();
            guitarsList = new List<Guitar>();
        }
        /// <summary>
        /// Propiedades de la clase Factory
        /// </summary>
        public List<Part> PartsList
        {
            get
            {
                return partsList;
            }
            set
            {
                partsList = value;
            }
        }
        public List<Guitar> GuitarsList
        {
            get
            {
                return guitarsList;
            }
            set
            {
                guitarsList = value;
            }
        }
        /// <summary>
        /// A partir de los parametros que le damos genera un objeto en la lista de piezas con dichas caracteristicas
        /// </summary>
        public bool AddPart(string piece, string type,string manufacturer)
        {
            if (string.IsNullOrWhiteSpace(piece) != true || 
                string.IsNullOrWhiteSpace(type) != true ||
                string.IsNullOrWhiteSpace(manufacturer) != true)
            {
                Part part;

                int maxId = PartsList.Max(t => t.Id);
                int id = maxId + 1;
                
                switch (piece)
                {
                    case "CLAVIJAS":
                        part = new Tuners {Id = id, Type = type, EntryDate = DateTime.Now.ToString("dd.MM.yy"), Manufacturer = manufacturer };
                        PartsList.Add(part);
                        break;
                    case "ELECTRONICA":
                        part = new Electronics {Id = id, Type = type, EntryDate = DateTime.Now.ToString("dd.MM.yy"), Manufacturer = manufacturer };
                        PartsList.Add(part);
                        break;
                    case "MADERA":
                        part = new Wood {Id = id, Type = type, EntryDate = DateTime.Now.ToString("dd.MM.yy"), Manufacturer = manufacturer };
                        PartsList.Add(part);
                        break;
                    case "PICKUPS":
                        part = new Pickup {Id = id, Type = type, EntryDate = DateTime.Now.ToString("dd.MM.yy"), Manufacturer = manufacturer };
                        PartsList.Add(part);
                        break;                   
                }

                return true;
            }

            return false;
        }
        /// <summary>
        /// Remueve un objeto de la lista de partes a partir del indice pasado
        /// </summary>
        public void removePart(int index)
        {
            PartsList.RemoveAt(index);
        }
        /// <summary>
        /// Agrega un obhjeto a la lista de productos con los parametros obtenidos como caracteristicas
        /// </summary>
        public bool AddGuitar(string wood, string pickup, string electronic, string tuner, string guitarType)
        {
            if (string.IsNullOrWhiteSpace(wood) != true ||
                string.IsNullOrWhiteSpace(pickup) != true ||
                string.IsNullOrWhiteSpace(electronic) != true ||
                string.IsNullOrWhiteSpace(tuner) != true ||
                string.IsNullOrWhiteSpace(guitarType) != true)
            {
                Guitar guitar;

                switch (guitarType)
                {
                    case "LES PAUL":
                        guitar = new LesPaul { Wood = wood, Pickups = pickup, Electronics = electronic, Tuners = tuner, ManufactureDate = DateTime.Now.ToString("dd.MM.yy") };
                        guitarsList.Add(guitar);
                        break;
                    case "SG":
                        guitar = new SG { Wood = wood, Pickups = pickup, Electronics = electronic, Tuners = tuner, ManufactureDate = DateTime.Now.ToString("dd.MM.yy") };
                        guitarsList.Add(guitar);
                        break;
                    case "TELECASTER":
                        guitar = new Telecaster { Wood = wood, Pickups = pickup, Electronics = electronic, Tuners = tuner, ManufactureDate = DateTime.Now.ToString("dd.MM.yy") };
                        guitarsList.Add(guitar);
                        break;
                }
                return true;
            }
            return false;
        }
        
        public void OpenDB()
        {
            PartsList = parts.GetAll("Piezas");
        }
        
        /// <summary>
        ///Genera una lista de piezas a partir del archivo xml ubicado en el PATH pasado como parametro.
        /// </summary>
        public bool OpenPartsFile(string filePath)
        {
            SerializeConfig<List<Part>> auxList = new SerializeConfig<List<Part>>();
            List<Part> deserealizedList = new List<Part>();
            if (filePath != null)
            {
                try
                {
                    auxList.Deserialize(filePath, out deserealizedList);

                    PartsList = deserealizedList;

                    return true;

                }
                catch
                {
                    throw new Exception($"Error al querer Leer el achivo desde : {filePath}.");
                }
            }

            return false;            
        }

        
        
        /// <summary>
        /// Guarda en un archivo XML la lista de piezas en el PATH pasado como paramentro
        /// </summary>
        public bool SavePartsFile(string filePath)
        {
            if (filePath != null)
            {
                SerializeConfig<List<Part>> auxList = new SerializeConfig<List<Part>>();
                try
                {
                    auxList.Serialize(partsList, filePath);
                }
                catch
                {
                    throw new Exception($"Error al querer gaurdar el achivo en la ruta: {filePath}.");
                }
                return true;
            }
            return false;

        }
        /// <summary>
        ///Genera una lista de productos a partir del archivo xml ubicado en el PATH pasado como parametro.
        /// </summary>
        public void SaveGuitarsFile(string filePath)
        {
            SerializeConfig<List<Guitar>> auxList = new SerializeConfig<List<Guitar>>();
            try
            {
                auxList.Serialize(guitarsList, filePath);
            }
            catch
            {
                throw new Exception($"Error al querer gaurdar el achivo en la ruta: {filePath}.");
            }
        }
        /// <summary>
        /// Guarda en un archivo XML la lista de productos en el PATH pasado como paramentro
        /// </summary>
        public bool OpenGuitarsFile(string filePath)
        {
            SerializeConfig<List<Guitar>> auxList = new SerializeConfig<List<Guitar>>();
            List<Guitar> deserealizedList = new List<Guitar>();

            try
            {
                auxList.Deserialize(filePath, out deserealizedList);

            }
            catch
            {
                throw new Exception($"Error al querer Leer el achivo desde : {filePath}.");
            }

            GuitarsList = deserealizedList;

            return true;
        }

        public string StockInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("GUITARRAS FABRICADAS");
            sb.AppendLine("---------------------");
            foreach (Guitar item in GuitarsList)
            {
                sb.AppendLine($"Model: {item.ClassType}");
                sb.AppendLine($"{item.Wood} ");
                sb.AppendLine($"{item.Electronics} ");
                sb.AppendLine($"{item.Pickups} ");
                sb.AppendLine($"{item.Tuners} ");
                sb.AppendLine($"Manufacture Date: {item.ManufactureDate} ");
                sb.AppendLine("---------------------");

            }

            return sb.ToString();
        }
    }
}
