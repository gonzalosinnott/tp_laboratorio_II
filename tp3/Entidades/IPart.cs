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
        string Name { get; set; }
        string Type { get; set; }
        DateTime EntryDate { get; set; }
        string Manufacturer { get; set; }
        string getClassType();
    }
}
