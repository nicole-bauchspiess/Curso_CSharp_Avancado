using System; //namespace basico do .net que contem informações do programa

namespace Projeto2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();

            Console.WriteLine("entre com as medidas do triangulo x:");
            X.A = double.Parse(Console.ReadLine());
            X.B = double.Parse(Console.ReadLine());
            X.C = double.Parse(Console.ReadLine());

            Console.WriteLine("entre com as medidas do triangulo y:");
            Y.A = double.Parse(Console.ReadLine());
            Y.B = double.Parse(Console.ReadLine());
            Y.C = double.Parse(Console.ReadLine());

            Console.WriteLine("area do x: " + X.area().ToString("F2"));
            Console.WriteLine("area do y: " + Y.area().ToString("F2")) ;

        }
    }
}