using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {
        private string nome { get; set; }
        public string sobrenome { get; set;}

        private void Metodo1() { }

        public void Executar() { }
    }

    class Humano
    {
        protected string nome;
        private string sobrenome;
        internal int idade;
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 0;
        }
    }
}
