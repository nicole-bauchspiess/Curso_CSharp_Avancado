using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Pessoa
    {
        private string nome = "";
        private int idade; 

        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

     }
}
