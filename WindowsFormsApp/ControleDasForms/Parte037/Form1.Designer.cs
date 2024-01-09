namespace Parte037
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
			this.printPreview = new System.Windows.Forms.PrintPreviewControl();
			this.txtPrint = new System.Windows.Forms.RichTextBox();
			this.btnVisualizar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.printDoc = new System.Drawing.Printing.PrintDocument();
			this.SuspendLayout();
			// 
			// printPreview
			// 
			this.printPreview.Location = new System.Drawing.Point(425, 12);
			this.printPreview.Name = "printPreview";
			this.printPreview.Size = new System.Drawing.Size(363, 342);
			this.printPreview.TabIndex = 0;
			this.printPreview.Zoom = 0.28742514970059879D;
			// 
			// txtPrint
			// 
			this.txtPrint.Location = new System.Drawing.Point(13, 12);
			this.txtPrint.Name = "txtPrint";
			this.txtPrint.Size = new System.Drawing.Size(406, 342);
			this.txtPrint.TabIndex = 1;
			this.txtPrint.Text = "";
			// 
			// btnVisualizar
			// 
			this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVisualizar.Location = new System.Drawing.Point(229, 372);
			this.btnVisualizar.Name = "btnVisualizar";
			this.btnVisualizar.Size = new System.Drawing.Size(165, 66);
			this.btnVisualizar.TabIndex = 2;
			this.btnVisualizar.Text = "Visualizar";
			this.btnVisualizar.UseVisualStyleBackColor = true;
			this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Location = new System.Drawing.Point(406, 372);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(165, 66);
			this.btnImprimir.TabIndex = 3;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
			this.Controls.Add(this.btnVisualizar);
			this.Controls.Add(this.txtPrint);
			this.Controls.Add(this.printPreview);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PrintPreviewControl printPreview;
		private System.Windows.Forms.RichTextBox txtPrint;
		private System.Windows.Forms.Button btnVisualizar;
		private System.Windows.Forms.Button btnImprimir;
		private System.Drawing.Printing.PrintDocument printDoc;
	}
}

