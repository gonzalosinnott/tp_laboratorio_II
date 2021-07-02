using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Telecaster : Guitar
    {
        public Telecaster() : base()
        {
        }

        public override string Wood
        {
            get
            {
                return this.wood;
            }
            set
            {
                this.wood = value;
            }
        }
        public override string Pickups
        {
            get
            {
                return this.pickups;
            }
            set
            {
                this.pickups = value;
            }
        }
        public override string Tuners
        {
            get
            {
                return this.tuners;
            }
            set
            {
                this.tuners = value;
            }

        }
        public override string Electronics
        {
            get
            {
                return ElectronicType.Fender.ToString();
            }
            set
            {
                this.electronics = value;
            }

        }       
    }
}
