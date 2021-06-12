using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IParts
    {
        string Name { get; set; }
        DateTime EntryDate { get; set; }
    }
}
