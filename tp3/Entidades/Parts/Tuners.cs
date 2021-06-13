using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Tuners : Part
    {
        public Tuners() : base()
        {

        }

        protected Tuners(string classType, string name, string type, DateTime entryDate, string manufacturer) : base(classType, name, type, entryDate, manufacturer)
        {

        }
        public override string Name { get { return this.name; } set { this.name = value; } }
        public override string Type { get { return "N/A"; } set { this.type = value; } }
        public override string Manufacturer { get { return this.manufacturer; } set { this.manufacturer = value; } }
    }
}
