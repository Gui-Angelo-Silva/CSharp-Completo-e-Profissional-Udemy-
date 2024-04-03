namespace BibliotecaDLL
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
			this.listaResultado = new System.Windows.Forms.ListBox();
			this.btnExecutar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listaResultado
			// 
			this.listaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaResultado.FormattingEnabled = true;
			this.listaResultado.ItemHeight = 24;
			this.listaResultado.Location = new System.Drawing.Point(47, 27);
			this.listaResultado.Name = "listaResultado";
			this.listaResultado.Size = new System.Drawing.Size(706, 244);
			this.listaResultado.TabIndex = 0;
			// 
			// btnExecutar
			// 
			this.btnExecutar.Location = new System.Drawing.Point(305, 309);
			this.btnExecutar.Name = "btnExecutar";
			this.btnExecutar.Size = new System.Drawing.Size(190, 58);
			this.btnExecutar.TabIndex = 1;
			this.btnExecutar.Text = "Executar";
			this.btnExecutar.UseVisualStyleBackColor = true;
			this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 416);
			this.Controls.Add(this.btnExecutar);
			this.Controls.Add(this.listaResultado);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listaResultado;
		private System.Windows.Forms.Button btnExecutar;
	}
}

