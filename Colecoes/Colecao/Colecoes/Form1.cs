using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			Lista.Items.Clear();

			// Array
			string[] nomes = new string[3];
			nomes[0] = "Guilherme";
			nomes[1] = "Ana";
			nomes[2] = "Gabriel";

			// Lista Genérica
			List<string> nomes2 = new List<string>();

			nomes2.Add("Eduardo");
			nomes2.Add("Fabiana");
			nomes2.AddRange(nomes);

			//if (nomes2.Remove("Eduardo"))
			//{
			//	MessageBox.Show("Eduardo removido");
			//}
			//else
			//{
			//	MessageBox.Show("Não foi possível remover.");
			//}

			//         if (nomes2.Contains("Gustavo"))
			//         {
			//	MessageBox.Show("Contém");
			//         }
			//else
			//{
			//	MessageBox.Show("Não contém");
			//}

			//MessageBox.Show("Numero de elementos: " + nomes2.Count);

			//nomes2.Sort();

			//MessageBox.Show("Fabiana está no indíce: " + nomes2.IndexOf("Fabiana"));

			//nomes2.Insert(2, "João");

			//nomes2.RemoveAt(1);

			//nomes2.Clear();

			nomes2.Add("Guilherme");

            foreach (string nome in nomes2)
            {
				Lista.Items.Add(nome);
			}
        }
	}
}
