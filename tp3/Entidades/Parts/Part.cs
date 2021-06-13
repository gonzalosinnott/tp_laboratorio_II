using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Electronics))]
    [XmlInclude(typeof(Pickup))]
    [XmlInclude(typeof(Tuners))]
    [XmlInclude(typeof(Wood))]
    public abstract class Part : IParts
    {
        protected string classType;
        protected string name;
        protected string type;
        protected DateTime entryDate;
        protected string manufacturer;

        public Part() { }
        protected Part(string classType, string name, string type, DateTime entryDate, string manufacturer)
        {
            this.classType = ClassType;
            this.name = Name;
            this.type = Type;
            this.entryDate = EntryDate;
            this.manufacturer = Manufacturer;
        }

        public string ClassType { get { return getClassType(); } }
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
        public DateTime EntryDate { get; set; }
        public abstract string Manufacturer { get; set; }

        public string getClassType()
        {
            return this.GetType().Name;
        }
    }
}
