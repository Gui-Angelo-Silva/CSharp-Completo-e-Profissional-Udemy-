namespace LINQ_1
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
			this.lista = new System.Windows.Forms.ListBox();
			this.txtConsultar = new System.Windows.Forms.TextBox();
			this.btnExecutar = new System.Windows.Forms.Button();
			this.btnWhere = new System.Windows.Forms.Button();
			this.btnOrderBy = new System.Windows.Forms.Button();
			this.btnGroupBy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lista
			// 
			this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lista.FormattingEnabled = true;
			this.lista.ItemHeight = 25;
			this.lista.Location = new System.Drawing.Point(12, 12);
			this.lista.Name = "lista";
			this.lista.Size = new System.Drawing.Size(592, 654);
			this.lista.TabIndex = 0;
			// 
			// txtConsultar
			// 
			this.txtConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConsultar.Location = new System.Drawing.Point(611, 13);
			this.txtConsultar.Name = "txtConsultar";
			this.txtConsultar.Size = new System.Drawing.Size(184, 35);
			this.txtConsultar.TabIndex = 1;
			// 
			// btnExecutar
			// 
			this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExecutar.Location = new System.Drawing.Point(611, 55);
			this.btnExecutar.Name = "btnExecutar";
			this.btnExecutar.Size = new System.Drawing.Size(184, 57);
			this.btnExecutar.TabIndex = 2;
			this.btnExecutar.Text = "Executar";
			this.btnExecutar.UseVisualStyleBackColor = true;
			this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
			// 
			// btnWhere
			// 
			this.btnWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWhere.Location = new System.Drawing.Point(611, 118);
			this.btnWhere.Name = "btnWhere";
			this.btnWhere.Size = new System.Drawing.Size(184, 57);
			this.btnWhere.TabIndex = 3;
			this.btnWhere.Text = "Where";
			this.btnWhere.UseVisualStyleBackColor = true;
			this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
			// 
			// btnOrderBy
			// 
			this.btnOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrderBy.Location = new System.Drawing.Point(611, 181);
			this.btnOrderBy.Name = "btnOrderBy";
			this.btnOrderBy.Size = new System.Drawing.Size(184, 57);
			this.btnOrderBy.TabIndex = 4;
			this.btnOrderBy.Text = "Order By";
			this.btnOrderBy.UseVisualStyleBackColor = true;
			this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
			// 
			// btnGroupBy
			// 
			this.btnGroupBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGroupBy.Location = new System.Drawing.Point(611, 244);
			this.btnGroupBy.Name = "btnGroupBy";
			this.btnGroupBy.Size = new System.Drawing.Size(184, 57);
			this.btnGroupBy.TabIndex = 5;
			this.btnGroupBy.Text = "Group By";
			this.btnGroupBy.UseVisualStyleBackColor = true;
			this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 684);
			this.Controls.Add(this.btnGroupBy);
			this.Controls.Add(this.btnOrderBy);
			this.Controls.Add(this.btnWhere);
			this.Controls.Add(this.btnExecutar);
			this.Controls.Add(this.txtConsultar);
			this.Controls.Add(this.lista);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lista;
		private System.Windows.Forms.TextBox txtConsultar;
		private System.Windows.Forms.Button btnExecutar;
		private System.Windows.Forms.Button btnWhere;
		private System.Windows.Forms.Button btnOrderBy;
		private System.Windows.Forms.Button btnGroupBy;
	}
}

