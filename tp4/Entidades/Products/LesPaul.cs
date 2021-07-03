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
        protected LesPaul(int id, string classType, string wood, string pickups, string tuners, string electronics, string manufactureDate) : base(id, classType, wood, pickups, tuners, electronics, manufactureDate)
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
                return this.electronics;
            }
            set
            {
                this.electronics = value;
            }
            
        }       
    }
}
