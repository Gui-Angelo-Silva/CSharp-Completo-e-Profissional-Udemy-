namespace ThreadForms
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
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnPrincipal = new System.Windows.Forms.Button();
			this.btnContador = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(13, 13);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(775, 178);
			this.lblResultado.TabIndex = 0;
			// 
			// btnPrincipal
			// 
			this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrincipal.Location = new System.Drawing.Point(38, 339);
			this.btnPrincipal.Name = "btnPrincipal";
			this.btnPrincipal.Size = new System.Drawing.Size(206, 81);
			this.btnPrincipal.TabIndex = 1;
			this.btnPrincipal.Text = "Principal";
			this.btnPrincipal.UseVisualStyleBackColor = true;
			this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
			// 
			// btnContador
			// 
			this.btnContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContador.Location = new System.Drawing.Point(558, 339);
			this.btnContador.Name = "btnContador";
			this.btnContador.Size = new System.Drawing.Size(206, 81);
			this.btnContador.TabIndex = 2;
			this.btnContador.Text = "Contador";
			this.btnContador.UseVisualStyleBackColor = true;
			this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnContador);
			this.Controls.Add(this.btnPrincipal);
			this.Controls.Add(this.lblResultado);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnPrincipal;
		private System.Windows.Forms.Button btnContador;
	}
}

