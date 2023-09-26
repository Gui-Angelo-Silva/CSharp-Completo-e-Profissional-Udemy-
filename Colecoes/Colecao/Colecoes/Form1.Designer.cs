namespace Colecoes
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
			this.Lista = new System.Windows.Forms.ListBox();
			this.btnList = new System.Windows.Forms.Button();
			this.btnHashSet = new System.Windows.Forms.Button();
			this.btnDictionary = new System.Windows.Forms.Button();
			this.btnSortedList = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Lista
			// 
			this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lista.FormattingEnabled = true;
			this.Lista.ItemHeight = 29;
			this.Lista.Location = new System.Drawing.Point(12, 12);
			this.Lista.Name = "Lista";
			this.Lista.Size = new System.Drawing.Size(675, 526);
			this.Lista.TabIndex = 0;
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnList.Location = new System.Drawing.Point(693, 12);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(172, 55);
			this.btnList.TabIndex = 1;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnHashSet
			// 
			this.btnHashSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHashSet.Location = new System.Drawing.Point(693, 73);
			this.btnHashSet.Name = "btnHashSet";
			this.btnHashSet.Size = new System.Drawing.Size(172, 55);
			this.btnHashSet.TabIndex = 2;
			this.btnHashSet.Text = "HashSet";
			this.btnHashSet.UseVisualStyleBackColor = true;
			this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
			// 
			// btnDictionary
			// 
			this.btnDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDictionary.Location = new System.Drawing.Point(693, 134);
			this.btnDictionary.Name = "btnDictionary";
			this.btnDictionary.Size = new System.Drawing.Size(172, 55);
			this.btnDictionary.TabIndex = 3;
			this.btnDictionary.Text = "Dictionary";
			this.btnDictionary.UseVisualStyleBackColor = true;
			this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
			// 
			// btnSortedList
			// 
			this.btnSortedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSortedList.Location = new System.Drawing.Point(693, 195);
			this.btnSortedList.Name = "btnSortedList";
			this.btnSortedList.Size = new System.Drawing.Size(172, 55);
			this.btnSortedList.TabIndex = 4;
			this.btnSortedList.Text = "SortedList";
			this.btnSortedList.UseVisualStyleBackColor = true;
			this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 566);
			this.Controls.Add(this.btnSortedList);
			this.Controls.Add(this.btnDictionary);
			this.Controls.Add(this.btnHashSet);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.Lista);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lista Genéricas";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox Lista;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnHashSet;
		private System.Windows.Forms.Button btnDictionary;
		private System.Windows.Forms.Button btnSortedList;
	}
}

