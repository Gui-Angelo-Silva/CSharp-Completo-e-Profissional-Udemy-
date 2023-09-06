using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.nome = "Guilherme";

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobrenome);
            Console.WriteLine(p1.anoNascimento);
            Console.WriteLine(p1.idade);

            Pessoa p2 = new Pessoa("Guilherme", "Silva", 2005);

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.sobrenome);
            Console.WriteLine(p2.anoNascimento);
            Console.WriteLine(p2.idade);
            
            Pessoa p3 = new Pessoa("Rodrigo", "Silva", 1976);

            Console.WriteLine(p3.nome);
            Console.WriteLine(p3.sobrenome);
            Console.WriteLine(p3.anoNascimento);
            Console.WriteLine(p3.idade);

            Console.ReadKey();
        }
    }
}
