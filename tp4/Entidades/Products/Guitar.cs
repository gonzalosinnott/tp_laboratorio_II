using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(LesPaul))]
    [XmlInclude(typeof(SG))]
    [XmlInclude(typeof(Telecaster))]
    public class Guitar : IGuitar
    {
        protected string classType;
        protected int id;
        protected string wood;
        protected string pickups;
        protected string tuners;
        protected string electronics;
        protected string manufactureDate;

        public Guitar() { }
        protected Guitar(int id, string classType, string wood, string pickups, string tuners, string electronics, string manufactureDate)
        {
            this.id = Id;
            this.classType = ClassType;
            this.wood = Wood;
            this.pickups = Pickups;
            this.tuners = Tuners;
            this.electronics = Electronics;
            this.manufactureDate = ManufactureDate;
        }
        public int Id { get; set; }
        public virtual string ClassType { get { return getClassType(); } set { this.classType = getClassType(); } }
        public virtual string Wood { get; set; }
        public virtual string Pickups { get; set; }
        public virtual string Tuners { get; set; }
        public virtual string Electronics { get; set; }
        public string ManufactureDate
        {
            get
            {
                return this.manufactureDate;
            }
            set
            {
                this.manufactureDate = value;
            }
        }
        public string getClassType()
        {
            return this.GetType().Name;
        }


    }
}
