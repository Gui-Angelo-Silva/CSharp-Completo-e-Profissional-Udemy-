namespace ClasseImportante
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
			this.btnMessageBox = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnAleatorio = new System.Windows.Forms.Button();
			this.btnTimeSpan = new System.Windows.Forms.Button();
			this.btnDateTime = new System.Windows.Forms.Button();
			this.btnColor = new System.Windows.Forms.Button();
			this.btnFont = new System.Windows.Forms.Button();
			this.btnEnvironment = new System.Windows.Forms.Button();
			this.btnApplication = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMessageBox
			// 
			this.btnMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMessageBox.Location = new System.Drawing.Point(11, 293);
			this.btnMessageBox.Name = "btnMessageBox";
			this.btnMessageBox.Size = new System.Drawing.Size(186, 56);
			this.btnMessageBox.TabIndex = 0;
			this.btnMessageBox.Text = "MessageBox";
			this.btnMessageBox.UseVisualStyleBackColor = true;
			this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(7, 9);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(760, 281);
			this.lblResultado.TabIndex = 1;
			this.lblResultado.Text = "label1";
			// 
			// btnAleatorio
			// 
			this.btnAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAleatorio.Location = new System.Drawing.Point(203, 293);
			this.btnAleatorio.Name = "btnAleatorio";
			this.btnAleatorio.Size = new System.Drawing.Size(186, 56);
			this.btnAleatorio.TabIndex = 2;
			this.btnAleatorio.Text = "Aleatório";
			this.btnAleatorio.UseVisualStyleBackColor = true;
			this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
			// 
			// btnTimeSpan
			// 
			this.btnTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimeSpan.Location = new System.Drawing.Point(395, 293);
			this.btnTimeSpan.Name = "btnTimeSpan";
			this.btnTimeSpan.Size = new System.Drawing.Size(186, 56);
			this.btnTimeSpan.TabIndex = 3;
			this.btnTimeSpan.Text = "TimeSpan";
			this.btnTimeSpan.UseVisualStyleBackColor = true;
			this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
			// 
			// btnDateTime
			// 
			this.btnDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDateTime.Location = new System.Drawing.Point(587, 293);
			this.btnDateTime.Name = "btnDateTime";
			this.btnDateTime.Size = new System.Drawing.Size(186, 56);
			this.btnDateTime.TabIndex = 4;
			this.btnDateTime.Text = "DateTime";
			this.btnDateTime.UseVisualStyleBackColor = true;
			this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
			// 
			// btnColor
			// 
			this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnColor.Location = new System.Drawing.Point(12, 355);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(186, 56);
			this.btnColor.TabIndex = 5;
			this.btnColor.Text = "Color";
			this.btnColor.UseVisualStyleBackColor = true;
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// btnFont
			// 
			this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFont.Location = new System.Drawing.Point(203, 355);
			this.btnFont.Name = "btnFont";
			this.btnFont.Size = new System.Drawing.Size(186, 56);
			this.btnFont.TabIndex = 6;
			this.btnFont.Text = "Font";
			this.btnFont.UseVisualStyleBackColor = true;
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			// 
			// btnEnvironment
			// 
			this.btnEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnvironment.Location = new System.Drawing.Point(395, 355);
			this.btnEnvironment.Name = "btnEnvironment";
			this.btnEnvironment.Size = new System.Drawing.Size(186, 56);
			this.btnEnvironment.TabIndex = 7;
			this.btnEnvironment.Text = "Environment";
			this.btnEnvironment.UseVisualStyleBackColor = true;
			this.btnEnvironment.Click += new System.EventHandler(this.btnEnvironment_Click);
			// 
			// btnApplication
			// 
			this.btnApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApplication.Location = new System.Drawing.Point(587, 355);
			this.btnApplication.Name = "btnApplication";
			this.btnApplication.Size = new System.Drawing.Size(186, 56);
			this.btnApplication.TabIndex = 8;
			this.btnApplication.Text = "Application";
			this.btnApplication.UseVisualStyleBackColor = true;
			this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(785, 421);
			this.Controls.Add(this.btnApplication);
			this.Controls.Add(this.btnEnvironment);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.btnColor);
			this.Controls.Add(this.btnDateTime);
			this.Controls.Add(this.btnTimeSpan);
			this.Controls.Add(this.btnAleatorio);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnMessageBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMessageBox;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnAleatorio;
		private System.Windows.Forms.Button btnTimeSpan;
		private System.Windows.Forms.Button btnDateTime;
		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.Button btnFont;
		private System.Windows.Forms.Button btnEnvironment;
		private System.Windows.Forms.Button btnApplication;
	}
}

