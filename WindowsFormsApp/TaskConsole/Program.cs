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
			#region Task Parte 1
			//Task t = new Task(Tarefa);
			//t.Start();

			//Task t2 = Task.Run(Tarefa);

			//Task.Run(Tarefa);

			//Task.Factory.StartNew(Tarefa);

			//Task.Run(() => 
			//{
			//	for (int i = 0; i < 10; i++)
			//	{
			//		Console.WriteLine("Tarefa anônima.");
			//	}
			//});

			//for (int i = 0; i < 10; i++)
			//{
			//	Console.WriteLine("Principal.");
			//}

			//Console.ReadKey();
			#endregion

			//Task[] tasks =
			//{
			//	Task.Factory.StartNew(() => 
			//	{
			//		Console.WriteLine("Tarefa #1");
			//	}),


			//	Task.Factory.StartNew(() => 
			//	{
			//		Console.WriteLine("Tarefa #2");
			//	}),

			//	Task.Factory.StartNew(() => 
			//	{
			//		Console.WriteLine("Tarefa #3");
			//	})
			//};

			//Task.WaitAll(tasks);

			Task t1 = Task.Run(() => { Console.WriteLine("Comando #1"); });
			Task t2 = Task.Run(() => { Console.WriteLine("Comando #2"); });
			Task t3 = Task.Run(() => { Console.WriteLine("Comando #3"); });

			Task.WaitAll(t1, t2, t3);

			Console.WriteLine("Principal.");

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