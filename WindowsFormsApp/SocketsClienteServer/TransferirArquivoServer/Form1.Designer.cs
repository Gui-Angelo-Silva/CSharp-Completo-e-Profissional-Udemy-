namespace TransferirArquivoServer
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
			this.txtEnderecoIP = new System.Windows.Forms.TextBox();
			this.btnEstabelecerConexao = new System.Windows.Forms.Button();
			this.btnParaServidor = new System.Windows.Forms.Button();
			this.txtPorta = new System.Windows.Forms.NumericUpDown();
			this.txtPasta = new System.Windows.Forms.Label();
			this.listaLogs = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(776, 76);
			this.label1.TabIndex = 0;
			this.label1.Text = "Servidor para Compartilhar Arquivo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtEnderecoIP
			// 
			this.txtEnderecoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEnderecoIP.Location = new System.Drawing.Point(14, 100);
			this.txtEnderecoIP.Name = "txtEnderecoIP";
			this.txtEnderecoIP.Size = new System.Drawing.Size(383, 31);
			this.txtEnderecoIP.TabIndex = 1;
			this.txtEnderecoIP.Text = "127.0.0.1";
			// 
			// btnEstabelecerConexao
			// 
			this.btnEstabelecerConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEstabelecerConexao.Location = new System.Drawing.Point(12, 138);
			this.btnEstabelecerConexao.Name = "btnEstabelecerConexao";
			this.btnEstabelecerConexao.Size = new System.Drawing.Size(385, 65);
			this.btnEstabelecerConexao.TabIndex = 2;
			this.btnEstabelecerConexao.Text = "Estabelecer Conexão";
			this.btnEstabelecerConexao.UseVisualStyleBackColor = true;
			this.btnEstabelecerConexao.Click += new System.EventHandler(this.btnEstabelecerConexao_Click);
			// 
			// btnParaServidor
			// 
			this.btnParaServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnParaServidor.Location = new System.Drawing.Point(403, 138);
			this.btnParaServidor.Name = "btnParaServidor";
			this.btnParaServidor.Size = new System.Drawing.Size(385, 65);
			this.btnParaServidor.TabIndex = 3;
			this.btnParaServidor.Text = "Para Servidor";
			this.btnParaServidor.UseVisualStyleBackColor = true;
			this.btnParaServidor.Click += new System.EventHandler(this.btnParaServidor_Click);
			// 
			// txtPorta
			// 
			this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPorta.Location = new System.Drawing.Point(404, 100);
			this.txtPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.txtPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.txtPorta.Name = "txtPorta";
			this.txtPorta.Size = new System.Drawing.Size(120, 31);
			this.txtPorta.TabIndex = 4;
			this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// txtPasta
			// 
			this.txtPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPasta.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtPasta.Location = new System.Drawing.Point(12, 216);
			this.txtPasta.Name = "txtPasta";
			this.txtPasta.Size = new System.Drawing.Size(776, 30);
			this.txtPasta.TabIndex = 5;
			this.txtPasta.Text = "Clique para selecionar a pasta...";
			this.txtPasta.Click += new System.EventHandler(this.txtPasta_Click);
			// 
			// listaLogs
			// 
			this.listaLogs.BackColor = System.Drawing.SystemColors.Info;
			this.listaLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaLogs.FormattingEnabled = true;
			this.listaLogs.ItemHeight = 20;
			this.listaLogs.Location = new System.Drawing.Point(12, 272);
			this.listaLogs.Name = "listaLogs";
			this.listaLogs.Size = new System.Drawing.Size(776, 224);
			this.listaLogs.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 510);
			this.Controls.Add(this.listaLogs);
			this.Controls.Add(this.txtPasta);
			this.Controls.Add(this.txtPorta);
			this.Controls.Add(this.btnParaServidor);
			this.Controls.Add(this.btnEstabelecerConexao);
			this.Controls.Add(this.txtEnderecoIP);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEnderecoIP;
		private System.Windows.Forms.Button btnEstabelecerConexao;
		private System.Windows.Forms.Button btnParaServidor;
		private System.Windows.Forms.NumericUpDown txtPorta;
		private System.Windows.Forms.Label txtPasta;
		private System.Windows.Forms.ListBox listaLogs;
	}
}

