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
			m.Cumprimentar();
			m.Somar(10, 5);
			m.Apresentar("Guilherme", 18);

			Console.ReadKey();
		}
	}
}
