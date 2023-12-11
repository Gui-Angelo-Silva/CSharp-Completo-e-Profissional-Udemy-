using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte010
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			ListViewItem item1 = new ListViewItem("Guilherme");
			item1.SubItems.Add("17 99722-2467");
			item1.SubItems.Add("guilherme@gmail.com");

			ListViewItem item2 = new ListViewItem("Ana");
			item1.SubItems.Add("17 99833-3578");
			item1.SubItems.Add("ana@gmail.com");

			ListViewItem item3 = new ListViewItem("Gabriel");
			item1.SubItems.Add("17 99944-4689");
			item1.SubItems.Add("gabriel@gmail.com");

			ListViewItem item4 = new ListViewItem(new string[] { "Arthur", "17 99620-3389", "mail" });

			lista.Items.Add(item1);
			lista.Items.Add(item2);
			lista.Items.Add(item3);
			lista.Items.Add(item4);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//lista.Items.Clear();
			//lista.Items.Remove(lista.SelectedItems[0]);
			lista.Items.RemoveAt(1);
		}

		private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show(lista.SelectedItems[0].Text);
		}
	}
}
