using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class Calculadora
    {
        private static string ValidarOperador(char operador)
        {
            string operadorAux = operador.ToString();

            if (operadorAux == "")
            {
                operadorAux = " ";
            }

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
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            ///Ver como validar eleccion de operador
            if(operador[0].Equals(""))
            {
                operador[0] = " ";
            }
            char operadorAux = operador[0];

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

        
    }

}
