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

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.numero = double.Parse(strNumero);
        }

        
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
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


        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

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

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public string DecimalBinario(string numero)
        {
            if (string.IsNullOrEmpty(numero))
            {
                return "Valor Invalido";
            }
            return DecimalBinario(double.Parse(numero));
        }

        public string DecimalBinario(double numero)
        {
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
    }
}
