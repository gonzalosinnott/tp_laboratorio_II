using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Wood : Part
    {
        public Wood() : base()
        {

        }

        protected Wood(string classType, string name, string type, DateTime entryDate, string manufacturer) : base(classType, name, type, entryDate, manufacturer)
        {

        }
        public override string Name { get { return this.name; } set { this.name = value; } }
        public override string Type { get { return this.type; } set { this.type = value; } }
        public override string Manufacturer { get { return this.manufacturer; } set { this.manufacturer = value; } }

        
    }
}
