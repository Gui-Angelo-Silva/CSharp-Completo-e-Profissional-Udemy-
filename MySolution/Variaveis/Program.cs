﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
	internal class Program
	{
		enum Notas
		{
			Minimo = 10, 
			Media = 15, 
			Maximo = 20
		}

		struct Pessoa
		{
			public string nome;
			public int idade;
			public double altura;
		}

		static void Main(string[] args)
		{
			#region Numericas Integrais
			////Integral assinado
			//sbyte num1 = 10; // 8 bits, de 128 a 127
			//short num2 = 20; // 16 bits, -32.768 a 32.767
			//int num3 = 30; // 32 bits, -2.147.483.648 a 2.147.483.647
			//long num4 = 40; // 64 bits, -9.223.372.036.775.808 a 9.223.372.036.775.807

			////Integral sem sinal
			//byte num5 = 10; // 8 bits, intervalo de 0 a 255
			//ushort num6 = 20; // 16 bits, de 0 a 65.535
			//uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
			//ulong num8 = 40; // 64 bits, de 0 a 18.446.744.709.551.615

			//sbyte numero;
			//numero = 100;

			//numero = 120;
			//numero = num1;

			#endregion

			#region Números Reais
			//float real1 = 100.75f; // 32 bits, intervalo de 1,5 x 10-45 a 3,4 x 1038, precisão de 7 dígitos 
			//double real2 = 500.754; // 64 bits, intervalo de 5,0 x 10-324 a 1,7 x 10308, precisão de 15 dígitos
			//decimal real3 = 752538.457m; // 128 bits, intervalo de pelo menos -7,9 x 10-28 a 7,9 x 1028, com precisão de 28 dígitos

			//double valor;
			//valor = real1;
			#endregion

			#region Caractere
			//char letra = '\u0041';
			//char escape = '\n';
			//char literal = 'c';
			#endregion

			#region Boolean
			//bool verificar = false;
			//verificar = true;
			#endregion

			#region String (Cadeia de Caracteres)
			//string texto = @"Guilherme Silva\n 2005";
			//string mensagem = null;
			//mensagem = texto;
			#endregion

			#region Var
			//var valor = 100;
			//valor = 20;
			////Não aceita string pois já definiu seu valor como int
			//valor = "Gabriel";
			#endregion

			#region Object
			//object obj = false;
			//obj = 200;
			//obj = "Gabriel";
			#endregion

			#region Constantes
			//const double pi = 3.1415;
			//const string nome = "Gabriel ";
			#endregion

			#region Enum
			//Notas notasAlunos = Notas.Media;
			#endregion

			#region Struct
			Pessoa p1 = new Pessoa();
			p1.altura = 1.70;
			p1.idade = 18;
			p1.nome = "Guilherme";

			Pessoa p2 = new Pessoa()
			{
				nome = "Gabriel",
				idade = 13,
				altura = 1.55
			};

			p1.nome = "Guilherme Silva";
			#endregion

			Console.WriteLine(p1.nome);
			Console.WriteLine(p1.idade);
			Console.WriteLine(p1.altura);

			Console.ReadKey();
		}
	}
}
