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

			#region IndexOf / LastIndexOf
			//string nome = "Guilherme Silva";

			////int indice = nome.IndexOf('u', 5, 4);
			//int indice = nome.LastIndexOf("Silva");

			//label1.Text = "Indice: " + indice;
			#endregion

			#region Insert / Replace
			////string nome = "Angelo Silva";
			//string nome = "Guilherme Silva";

			////string nomeFinal = nome.Insert(0, "Guilherme ");
			//string nomeFinal = nome.Replace("Silva", "Angelo");

			//label1.Text = nomeFinal;
			#endregion

			#region Length / SubString
			//string nome = "Guilherme Silva";

			////int tam = nome.Length;
			////label1.Text = "O nome " + nome + " contém " + tam + " letras";

			////for (int i = 0; i < nome.Length; i++)
			////{
			////	label1.Text += nome[i] + "\n";
			////}

			//string parte = nome.Substring(nome.IndexOf(" "));

			//label1.Text = parte;
			#endregion


		}
	}
}
