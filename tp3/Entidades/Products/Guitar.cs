using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Guitar : IGuitar
    {
        protected string wood;
        protected string pickups;
        protected string tuners;
        protected string electronics;
        protected DateTime manufactureDate;

        public Guitar()
        {
            this.wood = Wood;
            this.pickups = Pickups;
            this.tuners = Tuners;
            this.electronics = Electronics;
            this.manufactureDate = ManufactureDate;
        }

        public abstract string Wood { get; set; }
        public abstract string Pickups { get; set; }
        public abstract string Tuners { get; set; }
        public abstract string Electronics { get; set; }
        public DateTime ManufactureDate
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

        public virtual string Datos()
        {
            return $"Piezas necesarias para armar la guitarra {typeof(Guitar)}"; 
        }
    }
}
