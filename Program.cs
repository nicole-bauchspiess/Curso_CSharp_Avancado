using System; //namespace basico do .net que contem informações do programa

namespace Projeto2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.setNome(Console.ReadLine());
            p1.setIdade(int.Parse(Console.ReadLine()));

            Pessoa p2 = new Pessoa();
            p2.setNome(Console.ReadLine());
            p2.setIdade(int.Parse(Console.ReadLine()));

            if(p1.getIdade() > p2.getIdade()) 
            {
                Console.WriteLine("Pessoa mais velha: " + p1.getNome());
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.getNome());
            }

        }
    }
}