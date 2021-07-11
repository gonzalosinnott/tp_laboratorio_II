using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Diagnostics;




namespace Entidades
{
    public class Factory
    {
        DAO dao = new DAO();
        FilesConfig<object> fileManager = new FilesConfig<object>();

        /// <summary>
        /// Atributos de la clase Factory
        /// </summary>
        protected List<Part> partsList;
        protected List<Guitar> guitarsList;

        /// <summary>
        /// Constructores de la clase Factory
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
        /// Ademas llama al metodo SavePiece de la clase DAO que guarda la infomracion en la base de datos
        /// </summary>
        public bool AddPart(string piece, string type, string manufacturer)
        {
            if (string.IsNullOrWhiteSpace(piece) != true ||
                string.IsNullOrWhiteSpace(type) != true ||
                string.IsNullOrWhiteSpace(manufacturer) != true)
            {
                Part part;
                int maxId;

                if (!PartsList.Any())
                {
                    maxId = 0;
                }
                else
                {
                    maxId = PartsList.Max(t => t.Id);
                }
                int id = maxId + 1;

                switch (piece)
                {
                    case "CLAVIJAS":
                        part = new Tuners { Id = id, Type = type, EntryDate = DateTime.Now.ToString("dd.MM.yy"), Manufacturer = manufacturer };
                        PartsList.Add(part);
                        break;
                    case "ELECTRONICA":
                        part = new Electronics { Id = id, Type = type, EntryDate = DateTime.Now.ToString("dd.MM.yy"), Manufacturer = manufacturer };
                        PartsList.Add(part);
                        break;
                    case "MADERA":
                        part = new Wood { Id = id, Type = type, EntryDate = DateTime.Now.ToString("dd.MM.yy"), Manufacturer = manufacturer };
                        PartsList.Add(part);
                        break;
                    case "PICKUPS":
                        part = new Pickup { Id = id, Type = type, EntryDate = DateTime.Now.ToString("dd.MM.yy"), Manufacturer = manufacturer };
                        PartsList.Add(part);
                        break;
                }
                dao.SavePiece(id, piece, type, manufacturer, DateTime.Now.ToString("dd.MM.yy"));
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
        /// Agrega un objeto a la lista de productos con los parametros obtenidos como caracteristicas
        /// Ademas llama al metodo SaveProduct de la clase DAO que lo guarda en la base de datos
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
                int maxId;

                if (!GuitarsList.Any())
                {
                    maxId = 0;
                }
                else
                {
                    maxId = GuitarsList.Max(t => t.Id);
                }
                int id = maxId + 1;

                switch (guitarType)
                {
                    case "LES PAUL":
                        guitar = new LesPaul {Id = id, Wood = wood, Pickups = pickup, Electronics = electronic, Tuners = tuner, ManufactureDate = DateTime.Now.ToString("dd.MM.yy") };
                        guitarsList.Add(guitar);
                        break;
                    case "SG":
                        guitar = new SG {Id = id, Wood = wood, Pickups = pickup, Electronics = electronic, Tuners = tuner, ManufactureDate = DateTime.Now.ToString("dd.MM.yy") };
                        guitarsList.Add(guitar);
                        break;
                    case "TELECASTER":
                        guitar = new Telecaster {Id = id, Wood = wood, Pickups = pickup, Electronics = electronic, Tuners = tuner, ManufactureDate = DateTime.Now.ToString("dd.MM.yy") };
                        guitarsList.Add(guitar);
                        break;
                }
                dao.SaveProduct(id, guitarType, wood, electronic, tuner, pickup, DateTime.Now.ToString("dd.MM.yy"));
                return true;
            }

            return false;
        }
        
        /// <summary>
        /// Carga las listas de partes y productos con la informacion de
        /// la base de datos
        /// </summary>
        public void OpenDB()
        {
            PartsList = dao.GetAllParts();
            GuitarsList = dao.GetAllProducts();
        }

        /// <summary>
        /// Elimina de la base de datos el objeto con Id que
        /// coincida con el valor pasado como parametro
        /// </summary>
        public void deleteDB(int id)
        {
            dao.DeletePiece(id);
        } 
        
        /// <summary>
        /// Guarda en un archivo XML la lista de piezas en el PATH pasado como parametro
        /// </summary>
        public bool CreateXml<T>(string filePath, List<T> list)
        {
            if (filePath != null && list != null)
            {
                fileManager.XmlCreation<T>(filePath, list);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Guarda en un archivo PDF la lista de piezas en el PATH pasado como parametro
        /// </summary>
        public bool CreatePdf(string info, string path)
        {
            if (info != null && path != null)
            {
                if(fileManager.PdfCreation(info, path) == true)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Crea un string a partir de un stringbuilder con la informacion
        /// de todos los productos de la lista de productos
        /// </summary>
        /// <returns></returns>
        public string ProductsInfo()
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
                sb.AppendLine($"Serial Number: {item.ClassType.TipoProducto()}-{item.Id}");              
                sb.AppendLine("---------------------");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Crea un string a partir de un stringbuilder con la informacion
        /// de todos las partes de la lista de partes
        /// </summary>
        /// <returns></returns>
        public string PartsInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PIEZAS EN STOCK");
            sb.AppendLine("---------------------");
            foreach (Part item in PartsList)
            {
                sb.AppendLine($"Piece: {item.ClassType}");
                sb.AppendLine($"Type: {item.Type} ");
                sb.AppendLine($"Manufacturer: {item.Manufacturer} ");
                sb.AppendLine($"Entry Date: {item.EntryDate} ");
                sb.AppendLine($"Serial Number: {item.ClassType.TipoProducto()}-{item.Id}");
                sb.AppendLine("---------------------");
            }
            return sb.ToString();
        }
    }
}
