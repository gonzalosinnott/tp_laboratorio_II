using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LesPaul : Guitar
    {
        public LesPaul() : base()
        {

        }

        public override string Body
        {            
            get
            {
                return WoodType.Cedro.ToString();
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
                return PickupsType.Humbucker.ToString();
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
                return ElectronicType.Gibson.ToString();
            }
            set
            {
                this.electronics = value;
            }
            
        }       
    }
}
