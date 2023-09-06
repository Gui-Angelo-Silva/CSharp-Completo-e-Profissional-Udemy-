using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Parte 1
			//Carro c = new Carro();
			//Bicicleta b = new Bicicleta();

			//c.Acelerar();
			//b.Acelerar();
			#endregion

			Humano humano = new Humano();
			Pessoa pessoa = new Pessoa();
			Homem homem = new Homem();

			Console.WriteLine("\nHumano");
			humano.Olhos();
			humano.Cabelos();

			Console.WriteLine("\nPessoa");
			pessoa.Olhos();
			pessoa.Cabelos();

			Console.WriteLine("\nHomem");
			homem.Olhos();
			homem.Cabelos();

			Console.ReadKey();
		}
	}
}
