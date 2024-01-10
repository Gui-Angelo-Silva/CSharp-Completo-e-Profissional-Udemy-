namespace Parte040
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
			this.folder = new System.Windows.Forms.FolderBrowserDialog();
			this.lblFolder = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblFolder
			// 
			this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFolder.Location = new System.Drawing.Point(57, 89);
			this.lblFolder.Name = "lblFolder";
			this.lblFolder.Size = new System.Drawing.Size(687, 153);
			this.lblFolder.TabIndex = 0;
			this.lblFolder.Text = "Clique e selecione uma pasta...\r\n";
			this.lblFolder.Click += new System.EventHandler(this.lblFolder_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblFolder);
			this.Name = "Form1";
			this.Text = " ";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folder;
		private System.Windows.Forms.Label lblFolder;
	}
}

