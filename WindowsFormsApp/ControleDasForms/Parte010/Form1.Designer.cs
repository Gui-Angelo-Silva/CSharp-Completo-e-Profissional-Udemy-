namespace Parte010
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
			this.lista = new System.Windows.Forms.ListView();
			this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lista
			// 
			this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colTelefone,
            this.colEmail});
			this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lista.FullRowSelect = true;
			this.lista.HideSelection = false;
			this.lista.LabelEdit = true;
			this.lista.Location = new System.Drawing.Point(12, 13);
			this.lista.MultiSelect = false;
			this.lista.Name = "lista";
			this.lista.Size = new System.Drawing.Size(775, 389);
			this.lista.TabIndex = 0;
			this.lista.UseCompatibleStateImageBehavior = false;
			this.lista.View = System.Windows.Forms.View.Details;
			this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
			// 
			// colNome
			// 
			this.colNome.Text = "Nome";
			this.colNome.Width = 200;
			// 
			// colTelefone
			// 
			this.colTelefone.Text = "Telefone";
			this.colTelefone.Width = 200;
			// 
			// colEmail
			// 
			this.colEmail.Text = "Email";
			this.colEmail.Width = 250;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(588, 408);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 63);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 485);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lista);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lista;
		private System.Windows.Forms.ColumnHeader colNome;
		private System.Windows.Forms.ColumnHeader colTelefone;
		private System.Windows.Forms.ColumnHeader colEmail;
		private System.Windows.Forms.Button button1;
	}
}

