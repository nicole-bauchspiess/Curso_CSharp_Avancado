using System; //namespace basico do .net que contem informações do programa

namespace Projeto2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o raio:");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.circunferencia(raio);
            double vol = Calculadora.volume(raio);
            Console.WriteLine("Circ: " + circ.ToString("F2"));
            Console.WriteLine("volume: " +  vol.ToString("F2"));
            Console.WriteLine("pi: " + Calculadora.getPi());


       

        }
    }
}