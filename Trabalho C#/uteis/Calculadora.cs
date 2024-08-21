using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_CSharp.uteis
{
    internal class Calculadora
    {
        public static float Somar(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        public static float Subtrair(float numero1, float numero2)
        {
            return numero1 - numero2;
        }

        public static float Dividir(float numero1, float numero2)
        {
            return numero1 / numero2;
        }

        public static float Multiplicar(float numero1, float numero2)
        {
            return numero1 * numero2;
        }

        public static int Fatorial(int numero1)
        {
            if (numero1 == 1)
            {
                return 1;
            }  
            else
            {
                return numero1 * Fatorial(numero1 - 1);
            }
        }
    }
}
