using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
	class Program
	{
		static void Main(string[] args)
		{
			//Forma a = new Forma();
			Forma b = new Triangulo();
			Forma c = new Circulo();
			Forma d = new Retangulo();

			//Console.WriteLine("Forma");
			//a.Desenhar();
			Console.WriteLine("Triângulo");
			b.Desenhar();
			Console.WriteLine("Círculo");
			c.Desenhar();
			Console.WriteLine("Retângulo");
			d.Desenhar();

			Console.ReadKey();
		}
	}
}
