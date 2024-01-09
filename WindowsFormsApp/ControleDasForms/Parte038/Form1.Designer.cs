namespace Parte038
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
			this.txtPrint = new System.Windows.Forms.RichTextBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
			this.printDoc = new System.Drawing.Printing.PrintDocument();
			this.SuspendLayout();
			// 
			// txtPrint
			// 
			this.txtPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrint.Location = new System.Drawing.Point(12, 12);
			this.txtPrint.Name = "txtPrint";
			this.txtPrint.Size = new System.Drawing.Size(776, 358);
			this.txtPrint.TabIndex = 0;
			this.txtPrint.Text = "";
			// 
			// btnImprimir
			// 
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Location = new System.Drawing.Point(318, 382);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(164, 56);
			this.btnImprimir.TabIndex = 1;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// printPreview
			// 
			this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreview.Enabled = true;
			this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
			this.printPreview.Name = "printPreview";
			this.printPreview.Visible = false;
			// 
			// printDoc
			// 
			this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.txtPrint);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtPrint;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.PrintPreviewDialog printPreview;
		private System.Drawing.Printing.PrintDocument printDoc;
	}
}

