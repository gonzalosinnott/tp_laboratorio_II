using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tremolo : Part
    {
        private TremoloType type;

        public Tremolo()
        {
            this.type = Type;
        }
        public TremoloType Type
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
