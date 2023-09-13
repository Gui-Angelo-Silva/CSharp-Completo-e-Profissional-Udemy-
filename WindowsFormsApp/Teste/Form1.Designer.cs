namespace Teste
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btn1 = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.ForeColor = System.Drawing.Color.DarkRed;
			this.btn1.Location = new System.Drawing.Point(273, 184);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(250, 100);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "Executar";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			this.btn1.MouseEnter += new System.EventHandler(this.btn1_MouseEnter);
			this.btn1.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
			this.lblTitulo.Location = new System.Drawing.Point(0, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(800, 100);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Título da Aplicação";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 447);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btn1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(200, 100);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(300, 100);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Minha Aplicação";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Label lblTitulo;
	}
}

