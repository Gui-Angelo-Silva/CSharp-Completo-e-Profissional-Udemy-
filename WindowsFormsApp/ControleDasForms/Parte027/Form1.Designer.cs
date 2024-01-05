namespace Parte027
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
			this.components = new System.ComponentModel.Container();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.contextoInicial = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextoFinal = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextoInicial.SuspendLayout();
			this.contextoFinal.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt1
			// 
			this.txt1.ContextMenuStrip = this.contextoInicial;
			this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt1.Location = new System.Drawing.Point(107, 41);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(585, 44);
			this.txt1.TabIndex = 0;
			// 
			// txt2
			// 
			this.txt2.ContextMenuStrip = this.contextoFinal;
			this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt2.Location = new System.Drawing.Point(107, 136);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(585, 44);
			this.txt2.TabIndex = 1;
			// 
			// contextoInicial
			// 
			this.contextoInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.recortarToolStripMenuItem});
			this.contextoInicial.Name = "contextoInicial";
			this.contextoInicial.Size = new System.Drawing.Size(119, 48);
			// 
			// contextoFinal
			// 
			this.contextoFinal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colarToolStripMenuItem});
			this.contextoFinal.Name = "contextoFinal";
			this.contextoFinal.Size = new System.Drawing.Size(181, 48);
			// 
			// copiarToolStripMenuItem
			// 
			this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
			this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copiarToolStripMenuItem.Text = "Copiar";
			this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
			// 
			// recortarToolStripMenuItem
			// 
			this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
			this.recortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.recortarToolStripMenuItem.Text = "Recortar";
			this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
			// 
			// colarToolStripMenuItem
			// 
			this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
			this.colarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.colarToolStripMenuItem.Text = "Colar";
			this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.contextoInicial.ResumeLayout(false);
			this.contextoFinal.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.ContextMenuStrip contextoInicial;
		private System.Windows.Forms.ContextMenuStrip contextoFinal;
		private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
	}
}

