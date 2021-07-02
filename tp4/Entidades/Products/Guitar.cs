using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Guitar : IGuitar
    {
        protected string classType;
        protected int id;
        protected string wood;
        protected string pickups;
        protected string tuners;
        protected string electronics;
        protected string manufactureDate;

        public Guitar()
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
        public abstract string Wood { get; set; }
        public abstract string Pickups { get; set; }
        public abstract string Tuners { get; set; }
        public abstract string Electronics { get; set; }
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
