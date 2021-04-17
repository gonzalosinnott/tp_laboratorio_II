using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        private static string ValidarOperador(char operador)
        {
            switch (operador)
            {
                case '+':
                    return operador.ToString();
                case '-':
                    return operador.ToString();
                case '/':
                    return operador.ToString();
                case '*':
                    return operador.ToString();
                default:
                    return "+";
            }
        }
        public static double Operar(Numero num1, Numero num2, string operador)
        {
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
