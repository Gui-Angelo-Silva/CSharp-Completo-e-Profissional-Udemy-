﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
	class Program
	{
		static void Main(string[] args)
		{
			Carro c = new Carro();
			Bicicleta b = new Bicicleta();

			c.Acelerar();
			b.Acelerar();

			Console.ReadKey();
		}
	}
}
