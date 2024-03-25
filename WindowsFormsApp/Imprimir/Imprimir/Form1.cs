using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprimir
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			printDocument1.Print();
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			#region Parte 1

			string texto = "Trabalhando com impressão.";
			Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
			Brush pincel = new SolidBrush(Color.Black);
			Point pontoInicial = new Point(100, 50);

			// Desenhar o documento para ser impresso
			e.Graphics.DrawString(texto, letra, pincel, pontoInicial);
			e.Graphics.DrawString("Guilherme Silva", letra, Brushes.Red, new Point(150, 150));
			e.Graphics.FillRectangle(Brushes.Green, new Rectangle(100, 220, 400, 100));

			#endregion
		}
	}
}
