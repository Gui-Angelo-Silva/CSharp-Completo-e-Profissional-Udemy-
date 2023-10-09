using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			//Task t = new Task(Tarefa);
			//t.Start();

			//Task t2 = Task.Run(Tarefa);

			//Task.Run(Tarefa);

			Task.Factory.StartNew(Tarefa);

			Task.Run(() => 
			{
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine("Tarefa anônima.");
				}
			});

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Principal.");
			}

			Console.ReadKey();
		}

		private static void Tarefa()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Tarefa do task.");
			}
		}
	}
}