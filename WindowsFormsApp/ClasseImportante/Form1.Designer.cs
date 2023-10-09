namespace ClasseImportante
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
			this.btnMessageBox = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnAleatorio = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMessageBox
			// 
			this.btnMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMessageBox.Location = new System.Drawing.Point(13, 382);
			this.btnMessageBox.Name = "btnMessageBox";
			this.btnMessageBox.Size = new System.Drawing.Size(186, 56);
			this.btnMessageBox.TabIndex = 0;
			this.btnMessageBox.Text = "MessageBox";
			this.btnMessageBox.UseVisualStyleBackColor = true;
			this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(13, 13);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(775, 124);
			this.lblResultado.TabIndex = 1;
			this.lblResultado.Text = "label1";
			// 
			// btnAleatorio
			// 
			this.btnAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAleatorio.Location = new System.Drawing.Point(205, 382);
			this.btnAleatorio.Name = "btnAleatorio";
			this.btnAleatorio.Size = new System.Drawing.Size(186, 56);
			this.btnAleatorio.TabIndex = 2;
			this.btnAleatorio.Text = "Aleatório";
			this.btnAleatorio.UseVisualStyleBackColor = true;
			this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAleatorio);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnMessageBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMessageBox;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnAleatorio;
	}
}

