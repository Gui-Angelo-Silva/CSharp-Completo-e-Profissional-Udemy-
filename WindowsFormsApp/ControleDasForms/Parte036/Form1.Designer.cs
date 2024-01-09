namespace Parte036
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
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.txtPrint = new System.Windows.Forms.RichTextBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.btnImprimir2 = new System.Windows.Forms.Button();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.SuspendLayout();
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// txtPrint
			// 
			this.txtPrint.Location = new System.Drawing.Point(128, 38);
			this.txtPrint.Name = "txtPrint";
			this.txtPrint.Size = new System.Drawing.Size(545, 275);
			this.txtPrint.TabIndex = 0;
			this.txtPrint.Text = "";
			// 
			// btnImprimir
			// 
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Location = new System.Drawing.Point(128, 347);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(171, 63);
			this.btnImprimir.TabIndex = 1;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.UseEXDialog = true;
			// 
			// btnImprimir2
			// 
			this.btnImprimir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir2.Location = new System.Drawing.Point(502, 347);
			this.btnImprimir2.Name = "btnImprimir2";
			this.btnImprimir2.Size = new System.Drawing.Size(171, 63);
			this.btnImprimir2.TabIndex = 2;
			this.btnImprimir2.Text = "Imprimir2";
			this.btnImprimir2.UseVisualStyleBackColor = true;
			this.btnImprimir2.Click += new System.EventHandler(this.btnImprimir2_Click);
			// 
			// pageSetupDialog1
			// 
			this.pageSetupDialog1.Document = this.printDocument1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnImprimir2);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.txtPrint);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.RichTextBox txtPrint;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.Button btnImprimir2;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
	}
}

