using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Executar_Click(object sender, EventArgs e)
		{
			#region Contains / ToString
			//string texto = "Este tipo de variável é alfanumérica.";

			//if (texto.Contains("tipo"))
			//{
			//label1.Text = "Contém.";
			//}
			//else
			//{
			//label1.Text = "Não Contém.";
			//}

			//int num = 5400;
			//bool res = true;

			//label1.Text = num.ToString();
			#endregion

			#region ToUpper / ToLower
			//string nome = "Guilherme Silva";

			////string nomeMaior = nome.ToUpper();

			//label1.Text = nome.ToLower();
			#endregion
		}
	}
}
