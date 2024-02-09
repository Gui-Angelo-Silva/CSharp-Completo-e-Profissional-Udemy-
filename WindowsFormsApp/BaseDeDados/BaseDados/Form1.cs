using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace BaseDados
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnInserir_Click(object sender, EventArgs e)
		{

		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{

		}

		private void btnEditar_Click(object sender, EventArgs e)
		{

		}

		private void btnProcurar_Click(object sender, EventArgs e)
		{

		}

		private void btnCriarTabela_Click(object sender, EventArgs e)
		{

		}

		private void btnConectar_Click(object sender, EventArgs e)
		{
			#region SQLite
			string baseDados = Application.StartupPath + @"\db\DBSQLite.sdf";
			string strConnection = @"DataSource = " + baseDados + "; Version = 3";

            if (!File.Exists(baseDados))
            {
				SQLiteConnection.CreateFile(baseDados);
            }

			SQLiteConnection conexao = new SQLiteConnection(strConnection);

			try
			{
				conexao.Open();
				lblResultado.Text = "Conectado ao SQLite";
			}
			catch (Exception ex)
			{
				lblResultado.Text = "Erro ao Conectar SQLite \n" + ex;
			}
			finally
			{
				conexao.Close();
			}
            #endregion
        }
	}
}
