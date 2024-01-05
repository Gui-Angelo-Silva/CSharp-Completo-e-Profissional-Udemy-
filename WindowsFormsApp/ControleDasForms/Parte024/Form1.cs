using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte024
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			picture.BackgroundImage = Image.FromFile("imagens/logo.png");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			picture.BackgroundImage = Image.FromFile("imagens/peixe.jpg");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			picture.BackgroundImage = Image.FromFile("imagens/aguia.jpg");
		}
	}
}
