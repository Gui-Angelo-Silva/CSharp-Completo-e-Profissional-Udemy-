﻿namespace Colecoes
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.Lista = new System.Windows.Forms.ListBox();
			this.btnList = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Lista
			// 
			this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lista.FormattingEnabled = true;
			this.Lista.ItemHeight = 29;
			this.Lista.Location = new System.Drawing.Point(12, 12);
			this.Lista.Name = "Lista";
			this.Lista.Size = new System.Drawing.Size(675, 526);
			this.Lista.TabIndex = 0;
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnList.Location = new System.Drawing.Point(693, 12);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(172, 55);
			this.btnList.TabIndex = 1;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 566);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.Lista);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lista Genéricas";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox Lista;
		private System.Windows.Forms.Button btnList;
	}
}

