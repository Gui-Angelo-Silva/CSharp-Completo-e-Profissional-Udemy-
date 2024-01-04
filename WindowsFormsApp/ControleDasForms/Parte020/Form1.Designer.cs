namespace Parte020
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
			this.browser = new System.Windows.Forms.WebBrowser();
			this.Go = new System.Windows.Forms.Button();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnAvancar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// browser
			// 
			this.browser.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.browser.Location = new System.Drawing.Point(0, 45);
			this.browser.MinimumSize = new System.Drawing.Size(20, 20);
			this.browser.Name = "browser";
			this.browser.Size = new System.Drawing.Size(800, 405);
			this.browser.TabIndex = 0;
			// 
			// Go
			// 
			this.Go.Location = new System.Drawing.Point(716, 3);
			this.Go.Name = "Go";
			this.Go.Size = new System.Drawing.Size(75, 36);
			this.Go.TabIndex = 1;
			this.Go.Text = "Go";
			this.Go.UseVisualStyleBackColor = true;
			this.Go.Click += new System.EventHandler(this.Go_Click);
			// 
			// txtURL
			// 
			this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtURL.Location = new System.Drawing.Point(167, 5);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(543, 31);
			this.txtURL.TabIndex = 2;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.Location = new System.Drawing.Point(0, 6);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(75, 31);
			this.btnVoltar.TabIndex = 3;
			this.btnVoltar.Text = "<";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// btnAvancar
			// 
			this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAvancar.Location = new System.Drawing.Point(81, 6);
			this.btnAvancar.Name = "btnAvancar";
			this.btnAvancar.Size = new System.Drawing.Size(75, 31);
			this.btnAvancar.TabIndex = 4;
			this.btnAvancar.Text = ">";
			this.btnAvancar.UseVisualStyleBackColor = true;
			this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAvancar);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.txtURL);
			this.Controls.Add(this.Go);
			this.Controls.Add(this.browser);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser browser;
		private System.Windows.Forms.Button Go;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnAvancar;
	}
}

