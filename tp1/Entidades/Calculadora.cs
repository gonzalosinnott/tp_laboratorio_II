using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class Calculadora
    {
        /// <summary>
        /// Relaiza una operacion entre dos numeros y llama al metodo para validar el operador
        /// </summary>        
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            char operadorAux;

            if (operador == "")
            {
                operadorAux = ' ';
            }
            else
            {
                operadorAux = operador[0];
            }
            switch(ValidarOperador(operadorAux))
            {
                default:
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
            }
        }
        /// <summary>
        /// Valida el operador a utilizar
        /// </summary>
        private static string ValidarOperador(char operador)
        {
            string operadorAux = operador.ToString();

            switch (operadorAux)
            {
                case "+":
                    return operadorAux;
                case "-":
                    return operadorAux;
                case "/":
                    return operadorAux;
                case "*":
                    return operadorAux;
                default:
                    return "+";
            }
        }



    }

}
