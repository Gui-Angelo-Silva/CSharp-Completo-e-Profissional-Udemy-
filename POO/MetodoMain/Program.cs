using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMain
{
	class Program
	{
		static void Main(string[] args)
		{
			//string nome = args[0];
			string senha = "abc123";

			if (senha != args[1]) 
			{
				Console.WriteLine("Acesso Negado !");
			}
			else
			{ 
				Console.WriteLine("Olá " + args[0]);
			}

			Console.ReadKey();
		}
	}
}
