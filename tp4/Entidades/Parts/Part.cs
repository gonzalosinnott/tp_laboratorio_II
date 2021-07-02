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
    public class Part : IParts
    {
        protected int id;
        protected string classType;
        protected string type;
        protected string entryDate;
        protected string manufacturer;

        public Part() { }
        protected Part(int id, string classType, string type, string entryDate, string manufacturer)
        {
            this.id = Id;
            this.classType = ClassType;
            this.type = Type;
            this.entryDate = EntryDate;
            this.manufacturer = Manufacturer;
        }
        public int Id { get; set; }
        public  virtual string ClassType { get { return getClassType(); } set { this.classType = getClassType(); } }
        public virtual string Type { get; set; }
        public string EntryDate { get; set; }
        public virtual string Manufacturer { get; set; }

        public string getClassType()
        {
            return this.GetType().Name;
        }

        public virtual string Data()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{ClassType}: ");
            sb.Append($"Id: {Id} |");
            sb.Append($"Tipo: {Type} |");
            sb.Append($"Fabricante: {Manufacturer} |");
            sb.Append($"Ingreso: {EntryDate} |");

            return sb.ToString();
        }
    }
}
