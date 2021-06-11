using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSubRotinas
{
    public class Calculadora
    {
        /**
         * Assinatura da subrotina somar
         * Com dois parâmetros do tipo double, n1 e n2
         */ 
        public static double somar(double n1, double n2)
        {
            // Variável local res, que recebe a soma dos dois parâmetros
            // descritos na assinatura da subrotina.
            double res = n1 + n2;

            // Retorno da subrotina, tipo do retorno precisa "bater"
            // com o tipo de retorno descrito na assinatura.
            return res;
        }

        public static double subtrair(double n1, double n2)
        {
            return n1 - n2;
        }


        public static double multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }



        
    }
}
