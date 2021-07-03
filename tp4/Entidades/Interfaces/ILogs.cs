using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ILogs
    {
        bool SaveProduct(int id, string classType, string wood, string electronics, string pickups, string Tuners, string manufactureDate);
        bool SavePiece(int id, string classType, string type, string manufacturer, string manufactureDate);
    }
}
