using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Operadores matemáticos
			//int num1 = 15;
			//int num2 = 2;
			//int resultado = num1 + num2;

			//Console.WriteLine(num1 + num2);
			//Console.WriteLine(num1 - num2);
			//Console.WriteLine(num1 * num2);
			//Console.WriteLine(num1 / num2);
			//Console.WriteLine(num1 % num2);
			#endregion

			#region Procedência de Operadores
			//double num1 = 100;
			//double num2 = 10;
			//double num3 = 5;

			//double res = (num1 + num2) * (num3 / 3);
			#endregion

			#region Incremento e Decremento
			//int num1 = 10;

			//num1 = num1 + 1;
			//num1++;
			//++num1;
			//num1--;
			//--num1;

			//Console.WriteLine(num1++);

			//Console.WriteLine(num1);
			#endregion

			#region Concatenação
			//string nome = "Guilherme";
			//string sobreNome = "Artigas";
			//string nomeCompleto = nome + sobreNome + " " + 2005;
			#endregion

			#region Operadores Atribuição
			//int num1 = 10;

			//num1 = num1 + 20;
			//num1 += 20;
			//num1 -= 2;
			//num1 *= 3;
			//num1 /= 2;
			//num1 %= 2;

			//string nome = "Guilherme";
			//nome += " Silva";
			#endregion

			bool res = 100 == (50 * 2);
			bool res2 = (200 / 2) != (100 + 100);

			string nome = "Guilherme";
			bool res3 = nome == "Guilherme";

			Console.WriteLine(res3);
			Console.ReadKey();
		}
	}
}
