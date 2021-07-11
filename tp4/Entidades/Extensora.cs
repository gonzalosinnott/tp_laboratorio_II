using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Extensora
    {
        public static string TipoProducto(this string i)
        {
            string retorno;
            switch (i)
            {
                case "LesPaul":
                    retorno = "LP-";
                    break;
                case "SG":
                    retorno = "SG-";
                    break;
                case "Telecaster":
                    retorno = "TL-";
                    break;
                case "Electronics":
                    retorno = "EL-";
                    break;
                case "Pickup":
                    retorno = "PI-";
                    break;
                case "Tuners":
                    retorno = "TU-";
                    break;
                case "Wood":
                    retorno = "WO-";
                    break;
                default:
                    retorno = "N/A";
                    break;
            }
            return retorno;
        }
    }
}
