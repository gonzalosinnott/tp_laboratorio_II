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
                return this.body;
            }
            set
            {
                this.body = WoodType.Cedro.ToString();
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
                this.neck = WoodType.Caoba.ToString();
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
                this.pickups = PickupsType.Humbucker.ToString();
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
                this.electronics = ElectronicType.Gibson.ToString();
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
                this.serialNumber = $"LP{rand_num}";
            }
        }
    }
}
