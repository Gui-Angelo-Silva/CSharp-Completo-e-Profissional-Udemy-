using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDLL
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExecutar_Click(object sender, EventArgs e)
		{
			Matematica.Valor1 = 100;
			Matematica.Valor2 = 2;

			listaResultado.Items.Add("Soma: " + Matematica.Somar());
			listaResultado.Items.Add("Subtração: " + Matematica.Subtrair());
			listaResultado.Items.Add("Multiplicação: " + Matematica.Multiplicar());
			listaResultado.Items.Add("Divisão: " + Matematica.Dividir());
		}
	}
}
