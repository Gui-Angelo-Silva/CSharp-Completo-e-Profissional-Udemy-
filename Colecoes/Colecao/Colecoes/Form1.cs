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
			// Array
			string[] nomes = new string[3];
			nomes[0] = "Guilherme";
			nomes[1] = "Ana";
			nomes[2] = "Gabriel";

			// Lista Genérica
			List<string> nomes2 = new List<string>();

			nomes2.Add("Eduardo");
			nomes2.Add("FAbiana");
			nomes2.AddRange(nomes);

            foreach (string nome in nomes2)
            {
				Lista.Items.Add(nomes);
			}
        }
	}
}
