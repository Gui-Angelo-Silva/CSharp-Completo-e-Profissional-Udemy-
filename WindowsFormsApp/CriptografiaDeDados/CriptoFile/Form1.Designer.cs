namespace CriptoFile
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.btnCriptografarArquivo = new System.Windows.Forms.Button();
			this.btnDescriptografarArquivo = new System.Windows.Forms.Button();
			this.btnCriarChaves = new System.Windows.Forms.Button();
			this.btnObterChavePrivada = new System.Windows.Forms.Button();
			this.btnImportarChavePublica = new System.Windows.Forms.Button();
			this.btnExportarChavePublica = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(818, 127);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chave não definida";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtKey
			// 
			this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKey.Location = new System.Drawing.Point(299, 155);
			this.txtKey.Name = "txtKey";
			this.txtKey.Size = new System.Drawing.Size(245, 31);
			this.txtKey.TabIndex = 1;
			// 
			// btnCriptografarArquivo
			// 
			this.btnCriptografarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCriptografarArquivo.Location = new System.Drawing.Point(13, 233);
			this.btnCriptografarArquivo.Name = "btnCriptografarArquivo";
			this.btnCriptografarArquivo.Size = new System.Drawing.Size(264, 67);
			this.btnCriptografarArquivo.TabIndex = 2;
			this.btnCriptografarArquivo.Text = "Criptografar arquivo";
			this.btnCriptografarArquivo.UseVisualStyleBackColor = true;
			this.btnCriptografarArquivo.Click += new System.EventHandler(this.btnCriptografarArquivo_Click);
			// 
			// btnDescriptografarArquivo
			// 
			this.btnDescriptografarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDescriptografarArquivo.Location = new System.Drawing.Point(285, 233);
			this.btnDescriptografarArquivo.Name = "btnDescriptografarArquivo";
			this.btnDescriptografarArquivo.Size = new System.Drawing.Size(273, 67);
			this.btnDescriptografarArquivo.TabIndex = 3;
			this.btnDescriptografarArquivo.Text = "Descriptografar arquivo";
			this.btnDescriptografarArquivo.UseVisualStyleBackColor = true;
			this.btnDescriptografarArquivo.Click += new System.EventHandler(this.btnDescriptografarArquivo_Click);
			// 
			// btnCriarChaves
			// 
			this.btnCriarChaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCriarChaves.Location = new System.Drawing.Point(564, 233);
			this.btnCriarChaves.Name = "btnCriarChaves";
			this.btnCriarChaves.Size = new System.Drawing.Size(267, 67);
			this.btnCriarChaves.TabIndex = 4;
			this.btnCriarChaves.Text = "Criar chaves";
			this.btnCriarChaves.UseVisualStyleBackColor = true;
			this.btnCriarChaves.Click += new System.EventHandler(this.btnCriarChaves_Click);
			// 
			// btnObterChavePrivada
			// 
			this.btnObterChavePrivada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObterChavePrivada.Location = new System.Drawing.Point(564, 306);
			this.btnObterChavePrivada.Name = "btnObterChavePrivada";
			this.btnObterChavePrivada.Size = new System.Drawing.Size(267, 67);
			this.btnObterChavePrivada.TabIndex = 7;
			this.btnObterChavePrivada.Text = "Obter chave privada";
			this.btnObterChavePrivada.UseVisualStyleBackColor = true;
			this.btnObterChavePrivada.Click += new System.EventHandler(this.btnObterChavePrivada_Click);
			// 
			// btnImportarChavePublica
			// 
			this.btnImportarChavePublica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportarChavePublica.Location = new System.Drawing.Point(285, 306);
			this.btnImportarChavePublica.Name = "btnImportarChavePublica";
			this.btnImportarChavePublica.Size = new System.Drawing.Size(273, 67);
			this.btnImportarChavePublica.TabIndex = 6;
			this.btnImportarChavePublica.Text = "Importar chave pública";
			this.btnImportarChavePublica.UseVisualStyleBackColor = true;
			this.btnImportarChavePublica.Click += new System.EventHandler(this.btnImportarChavePublica_Click);
			// 
			// btnExportarChavePublica
			// 
			this.btnExportarChavePublica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportarChavePublica.Location = new System.Drawing.Point(13, 306);
			this.btnExportarChavePublica.Name = "btnExportarChavePublica";
			this.btnExportarChavePublica.Size = new System.Drawing.Size(264, 67);
			this.btnExportarChavePublica.TabIndex = 5;
			this.btnExportarChavePublica.Text = "Exportar chave pública";
			this.btnExportarChavePublica.UseVisualStyleBackColor = true;
			this.btnExportarChavePublica.Click += new System.EventHandler(this.btnExportarChavePublica_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 382);
			this.Controls.Add(this.btnObterChavePrivada);
			this.Controls.Add(this.btnImportarChavePublica);
			this.Controls.Add(this.btnExportarChavePublica);
			this.Controls.Add(this.btnCriarChaves);
			this.Controls.Add(this.btnDescriptografarArquivo);
			this.Controls.Add(this.btnCriptografarArquivo);
			this.Controls.Add(this.txtKey);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtKey;
		private System.Windows.Forms.Button btnCriptografarArquivo;
		private System.Windows.Forms.Button btnDescriptografarArquivo;
		private System.Windows.Forms.Button btnCriarChaves;
		private System.Windows.Forms.Button btnObterChavePrivada;
		private System.Windows.Forms.Button btnImportarChavePublica;
		private System.Windows.Forms.Button btnExportarChavePublica;
	}
}

