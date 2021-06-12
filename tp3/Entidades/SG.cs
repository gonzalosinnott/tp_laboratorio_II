using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SG : Guitar
    {
        public SG() : base()
        {

        }

        public override string Body
        {
            get
            {
                return WoodType.Caoba.ToString();
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
                return WoodType.Caoba.ToString();
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
                return PickupsType.P90.ToString();
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
                return TunersMakers.Gotoh.ToString();
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
                return ElectronicType.Gibson.ToString();
            }
            set
            {
                this.electronics = value;
            }

        }
    }
}
