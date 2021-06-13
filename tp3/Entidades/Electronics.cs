using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Electronics : Part
    {
        public Electronics() : base()
        {

        }
        public override string Name { get { return this.name; } set { this.name = value; } }
        public override string Type { get { return this.type; } set { this.type = value; } }
        public override string Manufacturer { get { return this.manufacturer; } set { this.manufacturer = value; } }
    }
}
