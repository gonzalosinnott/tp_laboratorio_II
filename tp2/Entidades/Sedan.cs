using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region "Atributos"
        ETipo tipo;
        /// <summary>
        /// Tipos de Sedan
        /// </summary>
        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas
        }
        #endregion

        #region "Constructores"
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
           : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region "Propiedades"
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region "Metodos"
        /// <summary>
        /// Muestra la informacion de un Sedan en un string
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0} TIPO : {1}", this.Tamanio, this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
