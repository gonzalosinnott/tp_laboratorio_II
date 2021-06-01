using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Electronics : Part
    {
        private ElectronicType type;

        public Electronics()
        {
            this.type = Type;
        }
        public ElectronicType Type
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
