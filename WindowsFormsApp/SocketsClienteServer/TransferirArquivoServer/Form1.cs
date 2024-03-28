using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoServer
{
	public partial class Form1 : Form
	{
		Task tarefa;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtPasta.Text = FTServer.PastaRepepcaoArquivos;
			FTServer.ListaMensagem = listaLogs;
		}

		private void btnEstabelecerConexao_Click(object sender, EventArgs e)
		{
			int porta = (int)txtPorta.Value;
			string endIp = txtEnderecoIP.Text;

			try
			{
				FTServer.EnderecoIP = endIp;
				FTServer.PortaHost = porta;

				tarefa = Task.Factory.StartNew(() =>
				{
					FTServer.IniciarServidor();
				});
			}
			catch (Exception ex)
			{
				listaLogs.Invoke(new Action(() =>
				{
					listaLogs.Items.Add("Erro ao conectar: " + ex.Message);
					listaLogs.SetSelected(listaLogs.Items.Count - 1, true);
				}));
			}
		}

		private void btnParaServidor_Click(object sender, EventArgs e)
		{
			try
			{
				Application.Restart();
			}
			catch (Exception ex )
			{
				listaLogs.Invoke(new Action(() =>
				{
					listaLogs.Items.Add("Erro ao conectar: " + ex.Message);
					listaLogs.SetSelected(listaLogs.Items.Count - 1, true);
				}));
			}
		}

		private void txtPasta_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
				FTServer.PastaRepepcaoArquivos = dialog.SelectedPath + @"\";
				txtPasta.Text = FTServer.PastaRepepcaoArquivos;
            }
        }
	}
}
