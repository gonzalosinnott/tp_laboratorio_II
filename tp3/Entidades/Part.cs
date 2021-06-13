using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Part : IParts
    {
        protected string classType;
        protected string name;
        protected string type;
        protected DateTime entryDate;
        protected string manufacturer;

        protected Part()
        {
            this.classType = ClassType;
            this.name = Name;
            this.type = Type;
            this.entryDate = EntryDate;
            this.manufacturer = Manufacturer;
        }

        public string ClassType { get { return getClassType(); } }
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
        public DateTime EntryDate { get; set; }
        public abstract string Manufacturer { get; set; }

        public string getClassType()
        {
            return this.GetType().Name;
        }
    }
}
