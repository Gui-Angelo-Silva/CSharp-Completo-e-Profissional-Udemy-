namespace ChatCliente
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
			this.txtServidorIP = new System.Windows.Forms.TextBox();
			this.numPortaHost = new System.Windows.Forms.NumericUpDown();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.btnConectar = new System.Windows.Forms.Button();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.txtMensagem = new System.Windows.Forms.TextBox();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numPortaHost)).BeginInit();
			this.SuspendLayout();
			// 
			// txtServidorIP
			// 
			this.txtServidorIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtServidorIP.Location = new System.Drawing.Point(13, 13);
			this.txtServidorIP.Name = "txtServidorIP";
			this.txtServidorIP.Size = new System.Drawing.Size(463, 29);
			this.txtServidorIP.TabIndex = 0;
			this.txtServidorIP.Text = "127.0.0.1";
			// 
			// numPortaHost
			// 
			this.numPortaHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numPortaHost.Location = new System.Drawing.Point(483, 13);
			this.numPortaHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numPortaHost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numPortaHost.Name = "numPortaHost";
			this.numPortaHost.Size = new System.Drawing.Size(136, 29);
			this.numPortaHost.TabIndex = 1;
			this.numPortaHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(13, 49);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(463, 29);
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.Text = "Visitante";
			// 
			// btnConectar
			// 
			this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConectar.Location = new System.Drawing.Point(483, 49);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(136, 29);
			this.btnConectar.TabIndex = 3;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// txtLog
			// 
			this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLog.Location = new System.Drawing.Point(13, 85);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(606, 396);
			this.txtLog.TabIndex = 4;
			// 
			// txtMensagem
			// 
			this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensagem.Location = new System.Drawing.Point(13, 488);
			this.txtMensagem.Name = "txtMensagem";
			this.txtMensagem.Size = new System.Drawing.Size(463, 29);
			this.txtMensagem.TabIndex = 5;
			this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
			// 
			// btnEnviar
			// 
			this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnviar.Location = new System.Drawing.Point(483, 488);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(136, 29);
			this.btnEnviar.TabIndex = 6;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.UseVisualStyleBackColor = true;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// labelStatus
			// 
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.labelStatus.Location = new System.Drawing.Point(13, 524);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(606, 122);
			this.labelStatus.TabIndex = 7;
			this.labelStatus.Text = "Não conectado";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 655);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.btnEnviar);
			this.Controls.Add(this.txtMensagem);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.btnConectar);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.numPortaHost);
			this.Controls.Add(this.txtServidorIP);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numPortaHost)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtServidorIP;
		private System.Windows.Forms.NumericUpDown numPortaHost;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.TextBox txtMensagem;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.Label labelStatus;
	}
}

