namespace TransferirArquivoClient
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
			this.lblCompartilharArquivo = new System.Windows.Forms.Label();
			this.txtPortaHost = new System.Windows.Forms.NumericUpDown();
			this.txtEnderecoIP = new System.Windows.Forms.TextBox();
			this.txtArquivo = new System.Windows.Forms.Label();
			this.btnEnviarArquivo = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtPortaHost)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCompartilharArquivo
			// 
			this.lblCompartilharArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCompartilharArquivo.Location = new System.Drawing.Point(12, 9);
			this.lblCompartilharArquivo.Name = "lblCompartilharArquivo";
			this.lblCompartilharArquivo.Size = new System.Drawing.Size(776, 76);
			this.lblCompartilharArquivo.TabIndex = 1;
			this.lblCompartilharArquivo.Text = "Clique para Compartilhar Arquivo";
			this.lblCompartilharArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPortaHost
			// 
			this.txtPortaHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPortaHost.Location = new System.Drawing.Point(408, 98);
			this.txtPortaHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.txtPortaHost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.txtPortaHost.Name = "txtPortaHost";
			this.txtPortaHost.Size = new System.Drawing.Size(120, 31);
			this.txtPortaHost.TabIndex = 6;
			this.txtPortaHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// txtEnderecoIP
			// 
			this.txtEnderecoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEnderecoIP.Location = new System.Drawing.Point(12, 98);
			this.txtEnderecoIP.Name = "txtEnderecoIP";
			this.txtEnderecoIP.Size = new System.Drawing.Size(383, 31);
			this.txtEnderecoIP.TabIndex = 5;
			this.txtEnderecoIP.Text = "127.0.0.1";
			// 
			// txtArquivo
			// 
			this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtArquivo.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtArquivo.Location = new System.Drawing.Point(8, 150);
			this.txtArquivo.Name = "txtArquivo";
			this.txtArquivo.Size = new System.Drawing.Size(771, 30);
			this.txtArquivo.TabIndex = 7;
			this.txtArquivo.Text = "Clique para selecionar a pasta...";
			// 
			// btnEnviarArquivo
			// 
			this.btnEnviarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnviarArquivo.Location = new System.Drawing.Point(10, 199);
			this.btnEnviarArquivo.Name = "btnEnviarArquivo";
			this.btnEnviarArquivo.Size = new System.Drawing.Size(385, 65);
			this.btnEnviarArquivo.TabIndex = 8;
			this.btnEnviarArquivo.Text = "Enviar Arquivo\r\n";
			this.btnEnviarArquivo.UseVisualStyleBackColor = true;
			// 
			// lblStatus
			// 
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
			this.lblStatus.Location = new System.Drawing.Point(13, 297);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(775, 247);
			this.lblStatus.TabIndex = 9;
			this.lblStatus.Text = "Status";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 553);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnEnviarArquivo);
			this.Controls.Add(this.txtArquivo);
			this.Controls.Add(this.txtPortaHost);
			this.Controls.Add(this.txtEnderecoIP);
			this.Controls.Add(this.lblCompartilharArquivo);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.txtPortaHost)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCompartilharArquivo;
		private System.Windows.Forms.NumericUpDown txtPortaHost;
		private System.Windows.Forms.TextBox txtEnderecoIP;
		private System.Windows.Forms.Label txtArquivo;
		private System.Windows.Forms.Button btnEnviarArquivo;
		private System.Windows.Forms.Label lblStatus;
	}
}

