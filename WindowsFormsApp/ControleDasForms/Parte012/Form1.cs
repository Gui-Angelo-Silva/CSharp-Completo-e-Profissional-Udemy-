namespace Parte012
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime data = monthCalendar1.TodayDate;

			MessageBox.Show(data.Day + " " + data.Month);
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			MessageBox.Show(monthCalendar1.TodayDate.ToString());
		}
	}
}