namespace Parte008
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
			this.dateTime = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTime
			// 
			this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTime.Location = new System.Drawing.Point(47, 40);
			this.dateTime.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
			this.dateTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
			this.dateTime.Name = "dateTime";
			this.dateTime.Size = new System.Drawing.Size(556, 38);
			this.dateTime.TabIndex = 0;
			this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(397, 307);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(238, 67);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 386);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTime);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTime;
		private System.Windows.Forms.Button button1;
	}
}

