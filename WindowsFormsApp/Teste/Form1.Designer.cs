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
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(257, 155);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(282, 115);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "Executar";
			this.btn1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.btn1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(200, 100);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(300, 100);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Minha Aplicação";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Click += new System.EventHandler(this.Form1_Click);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn1;
	}
}

