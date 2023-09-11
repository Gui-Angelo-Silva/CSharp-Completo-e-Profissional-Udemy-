using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
	abstract public class Forma
	{
		public int X { get; private set; }
		public int Y { get; private set; }
		public int Altura { get; set; }
		public int Largura { get; set; }
		public int Raio { get; set; }

		public virtual void Desenhar()
		{
			Console.WriteLine("Preparando-se para desenhar");
		}

		public virtual void Area()
		{
			double area = Largura * Altura;
			Console.WriteLine("Área: " + area);
		}

	}
	public class Circulo : Forma
	{
		public override void Desenhar()
		{
			Console.WriteLine("Desenhando um Círculo");
			base.Desenhar();
		}

		public override void Area()
		{
			double area = 3.14 * (Raio * Raio);
			Console.WriteLine("Área Círculo " + area);
		}
	}
	public class Retangulo : Forma
	{
		public override void Desenhar()
		{
			Console.WriteLine("Desenhando um Retângulo");
			base.Desenhar();
		}

		public override void Area()
		{
			base.Area();
		}
	}
	public class Triangulo : Forma
	{
		public override void Desenhar()
		{
			Console.WriteLine("Desenhando um Triângulo");
			base.Desenhar();
		}

		public override void Area()
		{
			double area = (Largura * Altura) / 2;
			Console.WriteLine("Área Triângulo " + area);
		}
	}
}
