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


            double p1 = (X.A + X.B + X.C) / 2;
            double p2 = (Y.A + Y.B + Y.C) / 2;

            double area1 = Math.Sqrt(p1 * (p1 - X.A) * (p1 - X.B) * (p1 - X.C));
            double area2 = Math.Sqrt(p2 * (p2 - Y.A) * (p2 - Y.B) * (p2 - Y.C));

            Console.WriteLine("area de x: " + area1);
            Console.WriteLine("area de y: " + area2);
            Console.Write("maior área: ");

            if (area1 > area2)
            {
                Console.WriteLine("area de x");
            }
            else
            {
                Console.WriteLine("area de y");
            }
        }
    }
}