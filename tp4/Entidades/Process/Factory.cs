﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;



namespace Entidades
{
    public class Factory
    {
        DAO dao = new DAO();

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
        
        public void OpenDB()
        {
            PartsList = dao.GetAllParts();
            GuitarsList = dao.GetAllProducts();
        }

        public void DeleteDB(int id)
        {
            dao.DeletePiece(id);
        } 
        
        /// <summary>
        /// Guarda en un archivo XML la lista de piezas en el PATH pasado como parametro
        /// </summary>
        public bool SavePartsXml(string filePath)
        {
            if (filePath != null)
            {
                SerializeConfig<List<Part>> auxList = new SerializeConfig<List<Part>>();
                try
                {
                    auxList.Serialize(PartsList, filePath);
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
        public bool SaveGuitarsXml(string filePath)
        {
            if (filePath != null)
            {
                SerializeConfig<List<Guitar>> auxList = new SerializeConfig<List<Guitar>>();
                try
                {
                    auxList.Serialize(GuitarsList, filePath);
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



        public string StockInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("GUITARRAS FABRICADAS");
            sb.AppendLine("---------------------");
            foreach (Guitar item in GuitarsList)
            {
                string model;

                
                sb.AppendLine($"Model: {item.ClassType}");
                sb.AppendLine($"{item.Wood} ");
                sb.AppendLine($"{item.Electronics} ");
                sb.AppendLine($"{item.Pickups} ");
                sb.AppendLine($"{item.Tuners} ");
                sb.AppendLine($"Manufacture Date: {item.ManufactureDate} ");
                switch (item.ClassType)
                {
                    case "LesPaul":
                        model = "LP-";
                        sb.AppendLine($"Serial Number: {model}{item.Id}");
                        break;
                    case "SG":
                        model = "SG-";
                        sb.AppendLine($"Serial Number: {model}{item.Id}");
                        break;
                    case "Telecaster":
                        model = "TL-";
                        sb.AppendLine($"Serial Number: {model}{item.Id}");
                        break;
                }
                sb.AppendLine("---------------------");
            }

            return sb.ToString();
        }
    }
}
