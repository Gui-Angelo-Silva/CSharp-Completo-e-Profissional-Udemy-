using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
	public partial class Form1 : Form
	{
		private delegate void AtualizaStatusCallback(string strMensagem);

		bool conectado = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (conectado)
			{
				Application.Exit();
				return;
			}

			if (txtEnderecoIP.Text == string.Empty)
			{
				MessageBox.Show("Informe o endereço IP.");
				txtEnderecoIP.Focus();
				return;
			}

			try
			{
				// Analisa o endereço IP do servidor informado no textbox
				IPAddress enderecoIP = IPAddress.Parse(txtEnderecoIP.Text);
				int portaHost = (int)numPorta.Value;

				// Cria uma nova instância do objeto ChatServidor
				Servidor mainServidor = new Servidor(enderecoIP, portaHost);

				// Vincula o tratamento de evento StatusChanged a mainServer_StatusChanged
				Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

				// Inicia o atendimento das conexões
				mainServidor.IniciaAtendimento();

				// Mostra que nos iniciamos o atendimento para conexões
				listaLog.Items.Add("Servidor ativo, aguardando usuários conectarem-se...");
				listaLog.SetSelected(listaLog.Items.Count - 1, true);
			}
			catch (Exception ex)
			{
				listaLog.Items.Add("Erro de conexão : " + ex.Message);
				listaLog.SetSelected(listaLog.Items.Count - 1, true);
				return;
			}

			conectado = true;
			txtEnderecoIP.Enabled = false;
			numPorta.Enabled = false;
			btnStart.ForeColor = Color.Red;
			btnStart.Text = "Sair";
		}

		public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
		{
			// Chama o método que atualiza o formulário
			this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
		}

		private void AtualizaStatus(string strMensagem)
		{
			// Atualiza o logo com mensagens
			listaLog.Items.Add(strMensagem);
			listaLog.SetSelected(listaLog.Items.Count - 1, true);
		}
	}
}
