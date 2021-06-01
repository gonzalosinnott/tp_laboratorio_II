using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Guitar
    {
        protected string body;
        protected string neck;
        protected string pickups;
        protected string tuners;
        protected string electronics;
        protected string serialNumber;
        protected string manufactureDate;

        public Guitar()
        {
            this.body = Body;
            this.neck = Neck;
            this.pickups = Pickups;
            this.tuners = Tuners;
            this.electronics = Electronics;
            this.serialNumber = SerialNumber;
            this.manufactureDate = ManufactureDate;
        }

        public abstract string Body { get; set; }
        public abstract string Neck { get; set; }
        public abstract string Pickups { get; set; }
        public abstract string Tuners { get; set; }
        public abstract string Electronics { get; set; }
        public abstract string SerialNumber { get; set; }
        public string ManufactureDate { get; set; }
    }
}
