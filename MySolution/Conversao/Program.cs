using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
	internal class Program
	{
		static void Main(string[] args)
		{
			byte num1 = 100; // 8 bits, de 0 a 255
			ushort num2; // 16 bits, 0 a 65.535

			float num3  = 1250.45f;
			double num4 = num3;

			num3 = num1;
			num2 = num1;

			int numero = 'C';

			Console.WriteLine(numero);
			Console.ReadKey();
		}
	}
}
