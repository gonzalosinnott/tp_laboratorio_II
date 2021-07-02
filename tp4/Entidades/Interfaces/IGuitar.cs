using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IGuitar
    {
        string Wood { get; set; }
        string Pickups { get; set; }
        string Tuners { get; set; }
        string Electronics { get; set; }
        string ManufactureDate { get; set; }
    }
}
