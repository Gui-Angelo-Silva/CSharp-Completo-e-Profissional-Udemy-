namespace LerEscrever
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
			this.txtConteudo = new System.Windows.Forms.TextBox();
			this.btnEscreverTxt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtConteudo
			// 
			this.txtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConteudo.Location = new System.Drawing.Point(13, 13);
			this.txtConteudo.Multiline = true;
			this.txtConteudo.Name = "txtConteudo";
			this.txtConteudo.Size = new System.Drawing.Size(775, 350);
			this.txtConteudo.TabIndex = 0;
			// 
			// btnEscreverTxt
			// 
			this.btnEscreverTxt.Location = new System.Drawing.Point(13, 386);
			this.btnEscreverTxt.Name = "btnEscreverTxt";
			this.btnEscreverTxt.Size = new System.Drawing.Size(169, 52);
			this.btnEscreverTxt.TabIndex = 1;
			this.btnEscreverTxt.Text = "Escrever Txt";
			this.btnEscreverTxt.UseVisualStyleBackColor = true;
			this.btnEscreverTxt.Click += new System.EventHandler(this.btnEscreverTxt_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEscreverTxt);
			this.Controls.Add(this.txtConteudo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtConteudo;
		private System.Windows.Forms.Button btnEscreverTxt;
	}
}

