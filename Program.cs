using System; //namespace basico do .net que contem informações do programa

namespace Projeto2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a largura e altura");
            Retangulo r = new Retangulo();

            r.setLargura(double.Parse(Console.ReadLine()));
            r.setAltura(double.Parse(Console.ReadLine()));

            Console.WriteLine("Area:" + r.area());
            Console.WriteLine("Perimetro:" + r.perimetro());
            Console.WriteLine("diagonal:" + r.diagonal());

        }
    }
}