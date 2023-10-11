﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void btnSegundo_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormSegundo frm = new FormSegundo("Bem vindo.");
			//frm.Mensagem = "Guilherme";
			//frm.Show();
			frm.ShowDialog();

            if (frm.Mensagem != null)
            {
				lblTitulo.Text = frm.Mensagem;
            }

            this.Show();
		}

		private void btnSegundoFormThread_Click(object sender, EventArgs e)
		{
			this.Close();
			Thread t = new Thread(() => Application.Run(new FormSegundo()));
			t.Start();
		}
	}
}
