using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factory
    {
        public static List<Part> partsList;
        private static List<Guitar> guitarsList;

        public Factory()
        {
            partsList = new List<Part>();
            guitarsList = new List<Guitar>();
        }

        public static List<Part> PartsList 
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
        public static List<Guitar> GuitarsList
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

        public static void AddPart(string piece, string name, string type, DateTime entryDate, string manufacturer)
        {
            Part part;
            if (string.IsNullOrWhiteSpace(name) != true)
            {
                switch (piece)
                {
                    case "CLAVIJAS":
                        part = new Tuners { Name = name, Type = type, EntryDate = entryDate, Manufacturer = manufacturer };
                        partsList.Add(part);
                        break;
                    case "ELECTRONICA":
                        part = new Electronics { Name = name, Type = type, EntryDate = entryDate, Manufacturer = manufacturer };
                        partsList.Add(part);
                        break;
                    case "MADERA":
                        part = new Wood { Name = name, Type = type, EntryDate = entryDate, Manufacturer = manufacturer };
                        partsList.Add(part);
                        break;
                    case "PICKUPS":
                        part = new Pickup { Name = name, Type = type, EntryDate = entryDate, Manufacturer = manufacturer };
                        partsList.Add(part);
                        break;
                }                
            }            
        }
        
    }
}
