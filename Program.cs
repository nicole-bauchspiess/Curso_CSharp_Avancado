using System; //namespace basico do .net que contem informações do programa

namespace Projeto2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2190.5;
            double preco2 = 500.3;
            double medida = 20.45786;

            Console.WriteLine($"{produto1}, cujo o valor é {preco1} \n {produto2}, cujo o preco é {preco2}");
            Console.WriteLine($"Registro: {idade}, codigo: {codigo} e genero {genero}");
            Console.WriteLine($"medida com todas casas decimais: {medida}, medida com 2 casas decimais: {medida:F2} ");

        }
    }
}