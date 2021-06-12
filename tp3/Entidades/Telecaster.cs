using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Telecaster : Guitar
    {
        private string tremolo;
        public Telecaster() : base()
        {
            this.tremolo = Tremolo;
        }

        public override string Body
        {
            get
            {
                return WoodType.Fresno.ToString();
            }
            set
            {
                this.body = value;
            }
        }
        public override string Neck
        {
            get
            {
                return WoodType.Nogal.ToString();
            }
            set
            {
                this.neck = value;
            }
        }
        public override string Pickups
        {
            get
            {
                return PickupsType.SingleCoil.ToString();
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
                return TunersMakers.Grover.ToString();
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
        public string Tremolo
        {           
            get
            {
                return TremoloType.Bigsby.ToString();
            }
            set
            {
                this.tremolo = value;
            }
        }        
    }
}
