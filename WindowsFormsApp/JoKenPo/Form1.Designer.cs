namespace JoKenPo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureResultado = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnPedra = new System.Windows.Forms.Button();
			this.btnPapel = new System.Windows.Forms.Button();
			this.btnTesoura = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureResultado)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(13, 13);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(609, 98);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Escolha: Pedra, Papel ou Tesoura...";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(20, 72);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(277, 72);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 200);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureResultado
			// 
			this.pictureResultado.Location = new System.Drawing.Point(531, 72);
			this.pictureResultado.Name = "pictureResultado";
			this.pictureResultado.Size = new System.Drawing.Size(200, 200);
			this.pictureResultado.TabIndex = 3;
			this.pictureResultado.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(83, 158);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "você";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(362, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "PC";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblResultado.Location = new System.Drawing.Point(625, 158);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(25, 25);
			this.lblResultado.TabIndex = 6;
			this.lblResultado.Text = "?";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(235, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "vs";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label5.Location = new System.Drawing.Point(492, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "=";
			// 
			// btnPedra
			// 
			this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPedra.Image = ((System.Drawing.Image)(resources.GetObject("btnPedra.Image")));
			this.btnPedra.Location = new System.Drawing.Point(20, 279);
			this.btnPedra.Name = "btnPedra";
			this.btnPedra.Size = new System.Drawing.Size(200, 200);
			this.btnPedra.TabIndex = 9;
			this.btnPedra.UseVisualStyleBackColor = true;
			this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
			// 
			// btnPapel
			// 
			this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPapel.Image = ((System.Drawing.Image)(resources.GetObject("btnPapel.Image")));
			this.btnPapel.Location = new System.Drawing.Point(277, 278);
			this.btnPapel.Name = "btnPapel";
			this.btnPapel.Size = new System.Drawing.Size(200, 200);
			this.btnPapel.TabIndex = 10;
			this.btnPapel.UseVisualStyleBackColor = true;
			this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
			// 
			// btnTesoura
			// 
			this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnTesoura.Image = ((System.Drawing.Image)(resources.GetObject("btnTesoura.Image")));
			this.btnTesoura.Location = new System.Drawing.Point(531, 278);
			this.btnTesoura.Name = "btnTesoura";
			this.btnTesoura.Size = new System.Drawing.Size(200, 200);
			this.btnTesoura.TabIndex = 11;
			this.btnTesoura.UseVisualStyleBackColor = true;
			this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 548);
			this.Controls.Add(this.btnTesoura);
			this.Controls.Add(this.btnPapel);
			this.Controls.Add(this.btnPedra);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureResultado);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureResultado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureResultado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnPedra;
		private System.Windows.Forms.Button btnPapel;
		private System.Windows.Forms.Button btnTesoura;
	}
}

