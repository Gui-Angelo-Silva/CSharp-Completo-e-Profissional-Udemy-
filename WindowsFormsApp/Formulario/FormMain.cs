using System;
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

		private void mFileNovo_Click(object sender, EventArgs e)
		{
			new Thread(() => Application.Run(new FormMain())).Start();
		}

		private void mFileAbrir_Click(object sender, EventArgs e)
		{
			Hide();
			FormSegundo f = new FormSegundo();
			f.ShowDialog();
			Show();
		}

		private void mFileSair_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mHelpSobreDev_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Guilherme Silva");
		}

		private void mHelpSobreVersao_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Versão 1.0");
		}

		private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (comboMenu.SelectedIndex == 0)
            {
				menuFile.Text = "File";
				menuHelp.Text = "Help";
            }
			else
			{
				menuFile.Text = "Arquivo";
				menuHelp.Text = "Ajuda";
			}
        }

		private void mPesquisar_KeyUp(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Return)
            {
				lblTitulo.Text = mPesquisar.Text;
				mPesquisar.Text = "";
            }
        }
	}
}
