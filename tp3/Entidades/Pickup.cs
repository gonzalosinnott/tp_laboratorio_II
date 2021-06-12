using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pickup : Part
    {
        private PickupsMaker maker;
        private PickupsType pickupType;
        public Pickup() : base()
        {
            this.maker = Maker;
            this.pickupType = Type;
        }

        public PickupsMaker Maker
        { 
            get
            { 
                return this.maker;
            }
            set
            {
                this.maker = value; 
            }
        }

        public PickupsType Type
        {
            get
            {
                return this.pickupType;
            }
            set
            {
                this.pickupType = value;
            }
        }
    }
}
