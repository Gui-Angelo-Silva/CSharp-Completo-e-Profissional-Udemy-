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
			desenhador.Clear(Color.Red);

			// Utilizar num picture box
			pictureBox1.BackgroundImage = folha;

			// Salvar o desenho num arquivo
			folha.Save(@"c:\curso\desenho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
		}
	}
}
