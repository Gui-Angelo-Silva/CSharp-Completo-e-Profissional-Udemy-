namespace DiretorioInfo
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
			this.lista = new System.Windows.Forms.ListBox();
			this.btnExecutar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lista
			// 
			this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lista.FormattingEnabled = true;
			this.lista.ItemHeight = 20;
			this.lista.Location = new System.Drawing.Point(13, 13);
			this.lista.Name = "lista";
			this.lista.Size = new System.Drawing.Size(775, 344);
			this.lista.TabIndex = 0;
			// 
			// btnExecutar
			// 
			this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExecutar.Location = new System.Drawing.Point(290, 374);
			this.btnExecutar.Name = "btnExecutar";
			this.btnExecutar.Size = new System.Drawing.Size(221, 64);
			this.btnExecutar.TabIndex = 1;
			this.btnExecutar.Text = "Executar";
			this.btnExecutar.UseVisualStyleBackColor = true;
			this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExecutar);
			this.Controls.Add(this.lista);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lista;
		private System.Windows.Forms.Button btnExecutar;
	}
}

