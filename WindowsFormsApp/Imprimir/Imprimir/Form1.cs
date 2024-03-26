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

			//string texto = "Trabalhando com impressão.";
			//Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
			//Brush pincel = new SolidBrush(Color.Black);
			//Point pontoInicial = new Point(100, 50);

			//// Desenhar o documento para ser impresso
			//e.Graphics.DrawString(texto, letra, pincel, pontoInicial);
			//e.Graphics.DrawString("Guilherme Silva", letra, Brushes.Red, new Point(150, 150));
			//e.Graphics.FillRectangle(Brushes.Green, new Rectangle(100, 220, 400, 100));

			#endregion

			#region Parte 2

			int x = printDocument1.DefaultPageSettings.Bounds.X;
			int y = printDocument1.DefaultPageSettings.Bounds.Y;
			int altura = printDocument1.DefaultPageSettings.Bounds.Height;
			int largura = printDocument1.DefaultPageSettings.Bounds.Width;

			string titulo = "Titulo da Página";
			Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
			Brush pincelTitutlo = new SolidBrush(Color.Red);
			Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, 100);
			StringFormat formatoTitulo = new StringFormat();
			formatoTitulo.Alignment = StringAlignment.Center;
			formatoTitulo.LineAlignment = StringAlignment.Center;

			string texto = "Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.";
			Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
			Brush pincel = new SolidBrush(Color.Black);
			Rectangle areaTexto = new Rectangle(x + 50, y + 200, largura - 100, altura - 400);	

			// Desenhar o documento para ser impresso
			e.Graphics.DrawString(titulo, letraTitulo, pincelTitutlo, areaTitulo, formatoTitulo);
			e.Graphics.DrawString(texto, letra, pincel, areaTexto);
			//e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTitulo);
			//e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);

			#endregion
		}
	}
}
