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
			#region Condicionais Simples
			//int valor = 5;

			//if (valor > 5)
			//{
			//	Console.WriteLine("Condição verdadeira");
			//}
			//else
			//{
			//	Console.WriteLine("Condição retornou falso");
			//}

			//Console.ReadKey();
			#endregion

			int valor = 15;

			if (valor < 5)
			{
				Console.WriteLine("Condição verdadeira");
			}
			else if (valor >= 5 && valor < 10)
			{
				Console.WriteLine("Condição alternativa 1");
			}
			else if (valor >= 10 && valor < 20)
			{
				Console.WriteLine("Condição alternativa 2");
			}
			else 
			{ 
				Console.WriteLine("Condição alternativa final"); 
			}

			Console.ReadKey();
		}
	}
}
