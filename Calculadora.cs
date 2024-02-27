using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Calculadora
    {
        private static double pi = 3.14;

        public static double getPi()
        {
            return pi;
        }

        public static double circunferencia(double raio)
        {
            return 2.0 * pi * raio;
        }

        public static double volume(double raio)
        {
            return 4.0 / 3.0 * pi * raio * raio * raio;
        }


    }


}

