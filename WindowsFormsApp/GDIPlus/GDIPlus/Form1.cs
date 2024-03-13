using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			// Criar uma folha em branco

			// Criar um desenhador

			// Utilizar o desenho ou imagem
		}

		private void btnDesenhar_Click(object sender, EventArgs e)
		{
			// Folha em branco
			Bitmap folha = new Bitmap(pictureBox1.Width, pictureBox1.Height);

			// Criar desenhador
			Graphics desenhador = Graphics.FromImage(folha);

			// Desenhar na folha
			desenhador.Clear(Color.White);

			#region Linhas
			Brush pincel = new SolidBrush(Color.Red);
			Pen lapis1 = new Pen(Color.Black, 5);
			Point ponto1 = new Point(100, 200);
			Point ponto2 = new Point(400, 100);


			Pen lapis2 = new Pen(Color.Black, 10);
			Point ponto3 = new Point(0, 0);
			Point ponto4 = new Point(100, 200);

			//desenhador.DrawLine(lapis1, ponto1, ponto2);
			//desenhador.DrawLine(lapis2, ponto3, ponto4);

			Point[] pontos = 
			{
				new Point(50,50),
				new Point(250,50),
				new Point(250,150),
				new Point(100,80),
				new Point(85,140),
			};

			desenhador.DrawLines(lapis1, pontos);
			#endregion

			// Utilizar num picture box
			pictureBox1.BackgroundImage = folha;

			// Salvar o desenho num arquivo
			folha.Save(@"c:\curso\desenho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
		}
	}
}
