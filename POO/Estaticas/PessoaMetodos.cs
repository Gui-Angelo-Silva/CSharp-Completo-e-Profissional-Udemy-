using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
	partial class Pessoa
	{
		public void Apresentar()
		{
			Console.WriteLine("Olá eu seu " + nome);
		}

		public static int CalcularIdade(int anoNascimento)
		{
			return DateTime.Now.Year - anoNascimento;
		}
	}
}
