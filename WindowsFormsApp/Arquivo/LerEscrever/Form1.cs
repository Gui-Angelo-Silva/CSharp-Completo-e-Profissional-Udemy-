﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LerEscrever
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEscreverTxt_Click(object sender, EventArgs e)
		{
			string path = @"c:\teste\file.txt";

			StreamWriter writer = new StreamWriter(path, true, Encoding.Default);

			//string linha = txtConteudo.Text;
			//writer.WriteLine(linha);

			string txt = txtConteudo.Text;
			writer.Write(txt);

			//writer.Flush();
			//writer.Dispose();
			writer.Close();
			txtConteudo.Clear();
		}

		private void btnLerTxt_Click(object sender, EventArgs e)
		{
			txtConteudo.Clear();
			string path = @"c:\teste\file.txt";
			StreamReader reader = new StreamReader(path, Encoding.Default);

			//string txt = reader.ReadToEnd();

			//string linha = reader.ReadLine();

			//while (linha != null)
			//{
			//	txtConteudo.Text += linha + "\n";
			//	linha = reader.ReadLine();	
			//}

			//linha += reader.ReadLine();
			//linha += reader.ReadLine();

			//txtConteudo.Text = txt;

			//while (!reader.EndOfStream)
			//{
			//	txtConteudo.Text += reader.Read();
			//}

			reader.Close();
		}
	}
}
