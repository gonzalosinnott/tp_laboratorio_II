using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;
        /// <summary>
        /// Cosntructor por defecto
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Sobrecarga del constructor donde asigna un numero en formato double
        /// </summary>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Sobrecarga del constructor donde asigna un numero en formato string
        /// </summary>
        public Numero(string strNumero)
        {
            this.numero = double.Parse(strNumero);
        }
        /// <summary>
        /// Setter del numero con validacion a traves del metodo ValidarNumero
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        /// <summary>
        /// Valida que el valor ingresado por el usuario sea un numero, cadso contrario devuelve 0
        /// </summary>
        private double ValidarNumero(string txtNumero)
        {
            double num;

            if (double.TryParse(txtNumero, out num) == true)
            {
                return num;
            }
            else
            {
                num = 0;
                return num;
            }
        }
        /// <summary>
        /// Sobrecarga operacion suma
        /// </summary>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Sobrecarga operacion resta
        /// </summary>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Sobrecarga operacion division
        /// </summary>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        /// <summary>
        /// Sobrecarga operacion multiplicacion
        /// </summary>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Valida que el numero ingresado sea valido y llama al metodo Decimal a binario
        /// </summary>
        public string DecimalBinario(string numero)
        {
            string aux = numero.Trim('(','D',')');

            if (string.IsNullOrEmpty(aux) || string.Compare(aux, "Valor Invalido")==0)
            {
                return "Valor Invalido";
            }
            
            return DecimalBinario(double.Parse(aux));
        }
        /// <summary>
        /// Convierte un numero decimal en binario
        /// </summary>
        public string DecimalBinario(double numero)
        {
            if (numero > int.MaxValue)
            {
                return "El valor del numero a convertir excede el int.MaxValue";
            }

            int numeroAux = Math.Abs((int)numero);
              
            string binario = "";

            if (numeroAux == 0)
            {
                binario = "0";
            }

            while (numeroAux > 0)
            {
                binario = numeroAux % 2 + binario;
                numeroAux = numeroAux / 2;
            }


            return binario;
        }
        /// <summary>
        /// Llama al metodo para validar que el numero sea binario y lo convierte en decimal
        /// </summary>
        public string BinarioDecimal(string binario)
        {
            string aux = binario.Trim('(', 'B', ')');
            if (EsBinario(aux) == false)
            {
                return "Valor Invalido";
            }

            int numero = int.Parse(aux);
            int residuo = 0;
            int exponente = 0;
            int resultado = 0;

            do
            {
                residuo = numero % 10;
                numero = numero / 10;
                resultado = resultado + (int)(residuo * Math.Pow(2, exponente));
                exponente++;
            } while (numero != 0);

            return resultado.ToString();          
        }
        /// <summary>
        /// Valida que el numero sea binario
        /// </summary>
        private bool EsBinario(string binario)
        {
            bool condicion = true;

            for(int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {                   
                    condicion = false;
                    break;
                }
            }
            return condicion;
        }
    }
}
