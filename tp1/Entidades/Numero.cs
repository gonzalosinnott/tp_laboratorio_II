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
        /// <param name="numero">Numero en fomrato double</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Sobrecarga del constructor donde asigna un numero en formato string
        /// </summary>
        /// <param name="strNumero">Numero en formato string</param>
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
        /// <param name="txtNumero">Numero en formato string</param>
        /// <returns>Numero</returns>
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
        /// <param name="n1">Numero 1</param>
        /// <param name="n2">NUmero 2</param>
        /// <returns>Suma de ambos numeros</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Sobrecarga operacion resta
        /// </summary>
        /// <param name="n1">Numero 1</param>
        /// <param name="n2">NUmero 2</param>
        /// <returns>Resta de ambos numeros</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Sobrecarga operacion division
        /// </summary>
        /// <param name="n1">Numero 1</param>
        /// <param name="n2">NUmero 2</param>
        /// <returns>Division de ambos numeros</returns>
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
        /// <param name="n1">Numero 1</param>
        /// <param name="n2">NUmero 2</param>
        /// <returns>Multiplicacion de ambos numeros</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Valida que el numero ingresado sea valido y llama al metodo Decimal a binario
        /// </summary>
        /// <param name="numero">Numero en formato string</param>
        /// <returns>Numero convertido a binario</returns>
        public string DecimalBinario(string numero)
        {
            string aux = numero.Trim('(','D',')');            

            if (string.IsNullOrEmpty(aux) || string.Compare(aux, "Valor Invalido")==0 ||string.Compare(aux, "El valor del numero a convertir excede el int,MaxValue") == 0)
            {
                return "Valor Invalido";
            }
            else
            {
                return DecimalBinario(double.Parse(aux));
            }
        }
        /// <summary>
        /// Convierte un numero decimal en binario
        /// </summary>
        /// <param name="numero">Numero en formato double</param>
        /// <returns>Numero convertido a binario</returns>
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
            return binario + "(B)";
        }
        /// <summary>
        /// Llama al metodo para validar que el numero sea binario y lo convierte en decimal
        /// </summary>
        /// <param name="binario">Numero en formato string</param>
        /// <returns>Numero convertido en decimal</returns>
        public string BinarioDecimal(string binario)
        {

            string aux = binario.Trim('(', 'B', ')');
            
            if (EsBinario(aux) == false || string.Compare(aux, "Valor Invalido") == 0)
            {
                return "Valor Invalido";
            }         
            
            if (double.Parse(aux) > int.MaxValue)
            {
                
                return "El valor del numero a convertir excede el int.MaxValue";
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

            return resultado.ToString() + "(D)";          
        }
        /// <summary>
        /// Valida que el numero sea binario
        /// </summary>
        /// /// <param name="binario">Numero en formato string</param>
        /// <returns>True si el numereo es decimal, False si no es decimal</returns>
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
