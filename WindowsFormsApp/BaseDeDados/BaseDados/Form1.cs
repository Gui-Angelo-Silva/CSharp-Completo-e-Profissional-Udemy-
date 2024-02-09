﻿using System;
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
using System.Data.SqlClient;

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
			#region
			string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
			string strConnection = @"Data Source = " + baseDados + "; Version = 3";

			SQLiteConnection conexao = new SQLiteConnection(strConnection);

			try
			{
				conexao.Open();

				SQLiteCommand comando = new SQLiteCommand();
				comando.Connection = conexao;

				int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
				string nome = txtNome.Text;
				string email = txtEmail.Text;

				comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";
			
				comando.ExecuteNonQuery();

				lblResultado.Text = "Registro inserido SQLite";
				comando.Dispose();
			}
			catch (Exception ex)
			{
				lblResultado.Text = ex.Message;
			}
			finally
			{
				conexao.Close();
			}
			#endregion
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
			#region SQLite
			string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
			string strConnection = @"Data Source = " + baseDados + "; Version = 3";

			SQLiteConnection conexao = new SQLiteConnection(strConnection);

			try
			{
				conexao.Open();

				SQLiteCommand comando = new SQLiteCommand();
				comando.Connection = conexao;

				comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
				comando.ExecuteNonQuery();

				lblResultado.Text = "Tabela Criada SQLite";
				comando.Dispose();
			}
			catch (Exception ex)
			{
				lblResultado.Text = ex.Message;
			}
			finally 
			{ 
				conexao.Close(); 
			}
			#endregion
		}

		private void btnConectar_Click(object sender, EventArgs e)
		{
			#region SQLite
			string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
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
