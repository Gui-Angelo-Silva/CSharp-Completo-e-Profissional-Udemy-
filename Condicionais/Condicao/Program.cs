using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int valor = 5;

			if (valor > 5)
			{
				Console.WriteLine("Condição verdadeira");
			}
			else
			{
				Console.WriteLine("Condição retornou falso");
			}

			Console.ReadKey();
		}
	}
}
