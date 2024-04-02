namespace ChatServer
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
			this.txtEnderecoIP = new System.Windows.Forms.TextBox();
			this.listaLog = new System.Windows.Forms.ListBox();
			this.numPorta = new System.Windows.Forms.NumericUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numPorta)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEnderecoIP
			// 
			this.txtEnderecoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEnderecoIP.Location = new System.Drawing.Point(13, 13);
			this.txtEnderecoIP.Name = "txtEnderecoIP";
			this.txtEnderecoIP.Size = new System.Drawing.Size(326, 29);
			this.txtEnderecoIP.TabIndex = 0;
			this.txtEnderecoIP.Text = "127.0.0.1";
			// 
			// listaLog
			// 
			this.listaLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaLog.FormattingEnabled = true;
			this.listaLog.ItemHeight = 20;
			this.listaLog.Location = new System.Drawing.Point(12, 48);
			this.listaLog.Name = "listaLog";
			this.listaLog.Size = new System.Drawing.Size(776, 404);
			this.listaLog.TabIndex = 1;
			// 
			// numPorta
			// 
			this.numPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numPorta.Location = new System.Drawing.Point(345, 13);
			this.numPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numPorta.Name = "numPorta";
			this.numPorta.Size = new System.Drawing.Size(120, 29);
			this.numPorta.TabIndex = 2;
			this.numPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnStart.Location = new System.Drawing.Point(482, 13);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(306, 29);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "Start Server";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 468);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.numPorta);
			this.Controls.Add(this.listaLog);
			this.Controls.Add(this.txtEnderecoIP);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numPorta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEnderecoIP;
		private System.Windows.Forms.ListBox listaLog;
		private System.Windows.Forms.NumericUpDown numPorta;
		private System.Windows.Forms.Button btnStart;
	}
}

