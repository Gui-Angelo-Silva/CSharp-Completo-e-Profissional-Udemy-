namespace Formulario
{
	partial class FormMain
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
			this.btnSegundo = new System.Windows.Forms.Button();
			this.btnSegundoFormThread = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(13, 13);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(775, 103);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Principal";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSegundo
			// 
			this.btnSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSegundo.Location = new System.Drawing.Point(20, 385);
			this.btnSegundo.Name = "btnSegundo";
			this.btnSegundo.Size = new System.Drawing.Size(195, 53);
			this.btnSegundo.TabIndex = 1;
			this.btnSegundo.Text = "Segundo Form";
			this.btnSegundo.UseVisualStyleBackColor = true;
			this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
			// 
			// btnSegundoFormThread
			// 
			this.btnSegundoFormThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSegundoFormThread.Location = new System.Drawing.Point(221, 385);
			this.btnSegundoFormThread.Name = "btnSegundoFormThread";
			this.btnSegundoFormThread.Size = new System.Drawing.Size(243, 53);
			this.btnSegundoFormThread.TabIndex = 2;
			this.btnSegundoFormThread.Text = "Segundo Form Thread";
			this.btnSegundoFormThread.UseVisualStyleBackColor = true;
			this.btnSegundoFormThread.Click += new System.EventHandler(this.btnSegundoFormThread_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSegundoFormThread);
			this.Controls.Add(this.btnSegundo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formulario Principal";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button btnSegundo;
		private System.Windows.Forms.Button btnSegundoFormThread;
	}
}

