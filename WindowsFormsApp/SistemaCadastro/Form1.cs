using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
	public partial class Form1 : Form
	{
		List<Pessoa> pessoas;
		public Form1()
		{
			InitializeComponent();

			pessoas = new List<Pessoa>();

			comboEC.Items.Add("Casado");
			comboEC.Items.Add("Solteiro");
			comboEC.Items.Add("Viuvo");
			comboEC.Items.Add("Separado");

			comboEC.SelectedIndex = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			int index = -1;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }

			if (txtNome.Text == "")
			{
				MessageBox.Show("Preencha o campo nome.");
				txtNome.Focus();
				return;
			}

			if (txtTelefone.Text == "")
			{
				MessageBox.Show("Preencha o campo telefone.");
				txtTelefone.Focus();
				return;
			}

			char sexo;

            if (radioM.Checked)
            {
				sexo = 'M';
            }
			else if (radioF.Checked)
			{
				sexo = 'F';
			}
			else
			{
				sexo = 'O';
			}

			Pessoa p = new Pessoa();
			p.Nome = txtNome.Text;
			p.DataNascimento = txtNome.Text;
			p.EstadoCivil = comboEC.SelectedIndex.ToString();
			p.Telefone = txtTelefone.Text;
			p.CasaPropria = checkCasa.Checked;
			p.Veiculo = checkVeiculo.Checked;
			p.Sexo = sexo;

			if (index < 0)
			{
				pessoas.Add(p);
			}
			else
			{
				pessoas[index] = p;
			}

			btnLimpar_Click(btnLimpar, EventArgs.Empty);

			Listar();
        }

		private void btnExcluir_Click(object sender, EventArgs e)
		{

		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{

		}

		private void Listar()
		{
			lista.Items.Clear();

			foreach (Pessoa p in pessoas)
			{
				lista.Items.Add(p.Nome);
			}
		}
	}
}
