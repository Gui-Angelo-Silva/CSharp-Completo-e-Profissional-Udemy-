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
		int x;
		int y;
		int altura;
		int largura;
		int num_linhas;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			largura = printDocument1.DefaultPageSettings.Bounds.Width;
			altura = printDocument1.DefaultPageSettings.Bounds.Height;
			x = 50;
			y = 50;
			num_linhas = 1;
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

			//int x = printDocument1.DefaultPageSettings.Bounds.X;
			//int y = printDocument1.DefaultPageSettings.Bounds.Y;
			//int altura = printDocument1.DefaultPageSettings.Bounds.Height;
			//int largura = printDocument1.DefaultPageSettings.Bounds.Width;

			//string titulo = "Titulo da Página";
			//Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
			//Brush pincelTitutlo = new SolidBrush(Color.Red);
			//Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, 100);
			//StringFormat formatoTitulo = new StringFormat();
			//formatoTitulo.Alignment = StringAlignment.Center;
			//formatoTitulo.LineAlignment = StringAlignment.Center;

			//string texto = "Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.Trabalhando com impressão.";
			//Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
			//Brush pincel = new SolidBrush(Color.Black);
			//Rectangle areaTexto = new Rectangle(x + 50, y + 200, largura - 100, altura - 400);	

			// Desenhar o documento para ser impresso
			//e.Graphics.DrawString(titulo, letraTitulo, pincelTitutlo, areaTitulo, formatoTitulo);
			//e.Graphics.DrawString(texto, letra, pincel, areaTexto);
			//e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTitulo);
			//e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);

			#endregion

			#region Parte 3

			List<string> linhas = new List<string>()
			{
				"1. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"2. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"3. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"4. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"5. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"6. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"7. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"8. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"9. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"10. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"11. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"12. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"13. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"14. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"15. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"16. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"17. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"18. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"19. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"20. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"21. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"22. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"23. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"24. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"25. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"26. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"27. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"28. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"29. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"30. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"31. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"32. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"33. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"34. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"35. Lorem, ipsum dolor sit amet consectetur adiplisicing elit.",
				"36. Lorem, ipsum dolor sit amet consectetur adiplisicing elit."
			};

			string titulo = "Titulo da Página";
			Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
			Brush pincelTitulo = new SolidBrush(Color.Red);
			Rectangle areaTitulo = new Rectangle(x, y, largura - 100, 100);
			StringFormat formatoTitulo = new StringFormat();
			formatoTitulo.Alignment = StringAlignment.Center;
			formatoTitulo.LineAlignment = StringAlignment.Center;

			//Desenhar o documento para ser impresso
			Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
			Brush pincel = new SolidBrush(Color.Black);

			while (num_linhas < linhas.Count)
            {
                if (num_linhas == 0)
                {
					e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo);
					y += 150;
                }

                e.Graphics.DrawString(linhas[num_linhas], letra, pincel, new Point(x, y));
				y += 30;
				num_linhas++;

                if (y >= altura - 50)
                {
					// Mudar de Página
					y = 50;
					e.HasMorePages = true;
					break;
                }
            }

			#endregion
		}
	}
}
