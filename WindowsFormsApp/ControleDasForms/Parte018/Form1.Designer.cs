namespace Parte018
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
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Informação do objeto";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(238, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(324, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Formulário Principal";
			this.toolTip1.SetToolTip(this.label1, "Título do formulário");
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(294, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(213, 61);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.toolTip2.SetToolTip(this.button1, "Botão para executar uma tarefa");
			this.button1.UseVisualStyleBackColor = true;
			// 
			// toolTip2
			// 
			this.toolTip2.BackColor = System.Drawing.SystemColors.HighlightText;
			this.toolTip2.ForeColor = System.Drawing.Color.Red;
			this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
			this.toolTip2.ToolTipTitle = "Aviso";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolTip toolTip2;
	}
}

