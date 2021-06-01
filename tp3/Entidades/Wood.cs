using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Wood : Part
    {
        private WoodType type;
        public Wood() : base()
        {
            this.type = Type;
        }

        public WoodType Type
        {
            get
            { 
                return this.type;
            } 
            set
            { 
                this.type = value;
            }
        }
    }
}
