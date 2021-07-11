using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Extensora
    {
        /// <summary>
        /// Extiende el tipo string para generar una identificacion
        /// a partir de los dos primeros caracteres del string pasado como argumento 
        /// </summary>
        public static string TipoProducto(this string i)
        {
            string firstTwoChar;
            return firstTwoChar = new string(i.Take(2).ToArray()).ToUpper();
        }
    }
}
