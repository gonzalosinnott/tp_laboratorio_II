using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Part
    {
        protected string name;
        protected DateTime entryDate;

        public Part()
        {
            this.name = Name;
            this.entryDate = EntryDate;
        }
        public virtual string Name { get { return this.name; } set { this.name = value; } }
        public virtual DateTime EntryDate { get { return this.entryDate; } set { this.entryDate = value; } }
    }
}
