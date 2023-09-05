using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			Metodos m = new Metodos();

			#region Métodos Simples
			//m.Cumprimentar();
			#endregion

			#region Métodos com Parâmetros
			//m.Somar(10, 5);
			//m.Apresentar("Guilherme", 18);
			#endregion

			#region Passagem de parâmetros por valor e por referência
			//int valor1 = 100;
			//int valor2 = 100;

			//m.AumentarValor(valor1);
			//m.AumentarRef(ref valor2);

			//Console.WriteLine("Valor 1: " + valor1);
			//Console.WriteLine("Valor 2: " + valor2);
			#endregion

			string nomeCompleto = m.MontaNome("Guilherme", "Silva");
			int codigoChar = m.CodigoChar('a');
			double pi = m.ValorPI();

			Console.WriteLine(nomeCompleto);
			Console.WriteLine(codigoChar);
			Console.WriteLine(pi);

			Console.ReadKey();
		}
	}
}
