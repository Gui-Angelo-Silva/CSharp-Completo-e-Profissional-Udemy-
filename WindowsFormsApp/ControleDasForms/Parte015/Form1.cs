namespace Parte015
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExecutar_Click(object sender, EventArgs e)
		{
			#region Parte 1
			//Task parte1 = Task.Factory.StartNew(new Action(() =>
			//{
			//	Thread.Sleep(2000);
			//	progress.Invoke(new Action(() => progress.Value = 25));
			//}));

			//Task parte2 = parte1.ContinueWith((x) =>
			//{
			//	Thread.Sleep(2000);
			//	progress.Invoke(new Action(() => progress.Value = 50));
			//});

			//Task parte3 = parte2.ContinueWith((x) =>
			//{
			//	Thread.Sleep(2000);
			//	progress.Invoke(new Action(() => progress.Value = 75));
			//});

			//Task parte4 = parte3.ContinueWith((x) =>
			//{
			//	Thread.Sleep(2000);
			//	progress.Invoke(new Action(() => progress.Value = 100));
			//});
			#endregion

			List<Task> tasks = new List<Task>();

			tasks.Add(new Task(new Action(() =>
			{
				Thread.Sleep(1000);
				progress.Invoke(new Action(() => progress.PerformStep()));
			})));

			tasks.Add(new Task(new Action(() =>
			{
				Thread.Sleep(4254);
				progress.Invoke(new Action(() => progress.PerformStep()));
			})));

			tasks.Add(new Task(new Action(() =>
			{
				Thread.Sleep(452);
				progress.Invoke(new Action(() => progress.PerformStep()));
			})));

			progress.Maximum = tasks.Count;
			progress.Step = 1;

			for (int i = 0; i < tasks.Count; i++)
			{
				tasks[i].Start();
			}
		}
	}
}