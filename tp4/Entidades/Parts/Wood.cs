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

        protected Wood(int id, string classType, string type, string entryDate, string manufacturer) : base(id, classType, type, entryDate, manufacturer)
        {

        }
        public override string Type { get { return this.type; } set { this.type = value; } }
        public override string Manufacturer { get { return this.manufacturer; } set { this.manufacturer = value; } }

        public override string Data()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{ClassType}: ");
            sb.Append($"Id: {Id} |");            
            sb.Append($"Tipo: {Type} |");
            sb.Append($"Fabricante: {Manufacturer} |");
            sb.Append($"Ingreso: {EntryDate} |");

            return sb.ToString();
        }
    }   
}
