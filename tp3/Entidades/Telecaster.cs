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
                return this.body;
            }
            set
            {
                this.body = WoodType.Fresno.ToString();
            }
        }
        public override string Neck
        {
            get
            {
                return this.neck;
            }
            set
            {
                this.neck = WoodType.Nogal.ToString();
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
                this.pickups = PickupsType.SingleCoil.ToString();
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
                this.tuners = TunersMakers.Grover.ToString();
            }
        }
        public override string Electronics
        {
            get
            {
                return this.electronics;
            }
            set
            {
                this.electronics = ElectronicType.Fender.ToString();
            }
        }
        public override string SerialNumber
        {
            get
            {
                return this.serialNumber;
            }
            set
            {
                Random rd = new Random();
                int rand_num = rd.Next(1, 1000);
                this.serialNumber = $"TE{rand_num}";
            }
        }
        public string Tremolo
        {
            get
            {
                return this.tremolo;
            }
            set
            {
                this.tremolo = TremoloType.Bigsby.ToString();
            }
        }

    }
}
