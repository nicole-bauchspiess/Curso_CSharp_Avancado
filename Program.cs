using System; //namespace basico do .net que contem informações do programa

namespace Projeto2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            Console.WriteLine("nome do produto: ");
            p1.setNome(Console.ReadLine());
            Console.WriteLine("quantidade do produto: ");
            p1.setQtd(int.Parse(Console.ReadLine()));
            Console.WriteLine("preço do produto: ");
            p1.setPreco(double.Parse(Console.ReadLine()));

            Console.WriteLine("Informa a quantidade a adicionar no estoque");
            int qtd = int.Parse(Console.ReadLine());
            p1.adicionaProdutos(qtd);
            Console.WriteLine("Nova quantidade do estoque: " + p1.getQtd());

            Console.WriteLine("Informa a quantidade a remover no estoque");
            qtd = int.Parse(Console.ReadLine());
            p1.removeProdutos(qtd);
            Console.WriteLine("Nova quantidade do estoque: " + p1.getQtd());
            Console.WriteLine("valor total em estoque: " + p1.valorEmEstoque());


        }
    }
}