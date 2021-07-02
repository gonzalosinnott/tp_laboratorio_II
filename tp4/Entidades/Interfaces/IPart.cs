using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IParts
    {
        string ClassType { get; }
        string Type { get; set; }
        string EntryDate { get; set; }
        string Manufacturer { get; set; }
        string getClassType();
    }
}
