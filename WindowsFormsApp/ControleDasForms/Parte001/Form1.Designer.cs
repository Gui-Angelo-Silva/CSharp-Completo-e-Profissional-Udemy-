namespace Parte001
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoEllipsis = true;
			this.lblTitulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTitulo.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
			this.lblTitulo.Location = new System.Drawing.Point(44, 50);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(20);
			this.lblTitulo.Size = new System.Drawing.Size(596, 126);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Guilherme Silva - Curso C# Completo e Profissional";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTitulo.Visible = false;
			this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
			this.lblTitulo.MouseEnter += new System.EventHandler(this.lblTitulo_MouseEnter);
			this.lblTitulo.MouseLeave += new System.EventHandler(this.lblTitulo_MouseLeave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 386);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
	}
}

