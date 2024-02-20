using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Retangulo
    {
        private double largura;
        private double altura;

        public double area()
        {
            return largura * altura;
        }
        public double perimetro()
        {
            return largura *2 +  altura *2;
        }

        public double diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) +  Math.Pow(altura, 2));
        }

        public double getLargura()
        {
            return largura;
        }

        public double getAltura()
        {

            return altura;
        }

        public void setLargura(double largura)
        {
            this.largura = largura;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }

    }
}
