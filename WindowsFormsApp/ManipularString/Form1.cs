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

			#region Split
			//string nomes = "Guilherme_Gabriel João-Eduardo";

			//char[] separador = { ' ', '-', '_' };

			//string[] resultado = nomes.Split(separador);

			//         foreach (var nome in resultado)
			//         {
			//	label1.Text += nome + "\n";
			//         }
			#endregion

			#region StartsWith / EndsWith
			//string nome = "Guilherme";

			////bool res = nome.StartsWith("Gui", StringComparison.OrdinalIgnoreCase);

			//bool res = nome.EndsWith("lher", StringComparison.OrdinalIgnoreCase);

			//         if (res)
			//         {
			//	label1.Text = "Positivo";
			//         }
			//         else
			//         {
			//	label1.Text = "Negativo";
			//         }

			#endregion

			#region Trim / TrimStart / TrimEnd
			//string mensagem = "   Ola Guilherme   ";

			////char[] c = { ' ', '-', '_', '5'};
			////string nova = mensagem.Trim(c);


			//label1.Text = ">" + mensagem.TrimStart() + "<";

			#endregion

			#region ComparteTo / Equals
			//string nome = "Guilherme";

			//string nome2 = "ana";

			////if (nome.Equals(nome2))
			////{
			////	label1.Text = "Positivo";
			////}
			////else
			////{
			////	label1.Text = "Negativo";
			////}

			//label1.Text = nome.CompareTo(nome2).ToString();
			#endregion

			#region Format
			decimal valor = 19.95m;
			int temp = 32;

			//string s = String.Format("O valor do produto é {0:C2} é a temperatura é {1]", valor, temp);

			//string s = String.Format("Hoje é {0:D} e são {0:T}", DateTime.Now);

			//string s = $"O valor do produto é {0:C2} é a temperatura é {1}";

			string s = $"Data: {DateTime.Now:D} e hora {DateTime.Now:T}";

			label1.Text = s;
			#endregion
		}
	}
}
