using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
	class Program
	{
		static void Main(string[] args)
		{
			MinhaClasse mClasse = new MinhaClasse();
			MinhaClasse m2 = null;
			
			OutraClasse outra = new OutraClasse();
			OutraClasse outra2 = outra;
		}
	}

	class MinhaClasse
	{

	}
}
