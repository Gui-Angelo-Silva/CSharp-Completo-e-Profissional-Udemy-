namespace Formulario
{
	partial class FormSegundo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnPrincipal = new System.Windows.Forms.Button();
			this.txtMensagem = new System.Windows.Forms.TextBox();
			this.btnRetorno = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(270, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Segunda Form";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPrincipal
			// 
			this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrincipal.Location = new System.Drawing.Point(612, 343);
			this.btnPrincipal.Name = "btnPrincipal";
			this.btnPrincipal.Size = new System.Drawing.Size(176, 63);
			this.btnPrincipal.TabIndex = 1;
			this.btnPrincipal.Text = "Principal";
			this.btnPrincipal.UseVisualStyleBackColor = true;
			this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
			// 
			// txtMensagem
			// 
			this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensagem.Location = new System.Drawing.Point(175, 167);
			this.txtMensagem.Name = "txtMensagem";
			this.txtMensagem.Size = new System.Drawing.Size(451, 40);
			this.txtMensagem.TabIndex = 2;
			// 
			// btnRetorno
			// 
			this.btnRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRetorno.Location = new System.Drawing.Point(430, 343);
			this.btnRetorno.Name = "btnRetorno";
			this.btnRetorno.Size = new System.Drawing.Size(176, 63);
			this.btnRetorno.TabIndex = 3;
			this.btnRetorno.Text = "Retorno";
			this.btnRetorno.UseVisualStyleBackColor = true;
			this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.Location = new System.Drawing.Point(248, 343);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(176, 63);
			this.btnFechar.TabIndex = 4;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// FormSegundo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 418);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnRetorno);
			this.Controls.Add(this.txtMensagem);
			this.Controls.Add(this.btnPrincipal);
			this.Controls.Add(this.label1);
			this.Name = "FormSegundo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FormSegundo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPrincipal;
		private System.Windows.Forms.TextBox txtMensagem;
		private System.Windows.Forms.Button btnRetorno;
		private System.Windows.Forms.Button btnFechar;
	}
}