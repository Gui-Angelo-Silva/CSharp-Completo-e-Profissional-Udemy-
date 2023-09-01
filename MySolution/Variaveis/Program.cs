using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Integral assinado
			//Integral assinado
			sbyte num1 = 10; // 8 bits, de 128 a 127
			short num2 = 20; // 16 bits, -32.768 a 32.767
			int num3 = 30; // 32 bits, -2.147.483.648 a 2.147.483.647
			long num4 = 40; // 64 bits, -9.223.372.036.775.808 a 9.223.372.036.775.807
			#endregion

			#region Integral sem sinal
			//Integral sem sinal
			byte num5 = 10; // 8 bits, intervalo de 0 a 255
			ushort num6 = 20; // 16 bits, de 0 a 65.535
			uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
			ulong num8 = 40; // 64 bits, de 0 a 18.446.744.709.551.615
			#endregion

			#region Exercício mudança de valor da variável.
			sbyte numero;
			numero = 100;

			numero = 120;
			numero = num1;

			Console.WriteLine(numero);
			Console.ReadKey();
			#endregion
		}
	}
}
