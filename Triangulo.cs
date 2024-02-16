using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Triangulo
    {

        public double A;
        public double B;
        public double C;

        public double area()
        {
            double p1 = (A + B +C) / 2;
            return Math.Sqrt(p1 * (p1 - A) * (p1 - B) * (p1 -C));


        }
    }
}
