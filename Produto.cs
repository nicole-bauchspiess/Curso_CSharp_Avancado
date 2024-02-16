using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Produto
    {
        private string Nome;
        private int Qtd;
        private double Preco;

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setQtd(int qtd)
        {
            this.Qtd = qtd;
        }
        public double getQtd()
        {

            return this.Qtd;
        }
        public void setPreco(double preco) 
        { 
            this.Preco = preco;
        }

        public double getPreco()
        {
            return Preco;
        }

        public void adicionaProdutos(int qtd)
        {
            this.Qtd += qtd;
        }

        public void removeProdutos(int qtd)
        {
            this.Qtd -= qtd;
        }

        public double valorEmEstoque()
        {
            return Qtd * Preco;
        }
    }
}
