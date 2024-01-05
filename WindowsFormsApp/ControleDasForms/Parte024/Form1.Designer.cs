namespace Parte024
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
			this.Container = new System.Windows.Forms.SplitContainer();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.picture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Container)).BeginInit();
			this.Container.Panel1.SuspendLayout();
			this.Container.Panel2.SuspendLayout();
			this.Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			this.SuspendLayout();
			// 
			// Container
			// 
			this.Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container.Location = new System.Drawing.Point(0, 0);
			this.Container.Name = "Container";
			// 
			// Container.Panel1
			// 
			this.Container.Panel1.Controls.Add(this.button3);
			this.Container.Panel1.Controls.Add(this.button1);
			this.Container.Panel1.Controls.Add(this.button2);
			// 
			// Container.Panel2
			// 
			this.Container.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Container.Panel2.Controls.Add(this.picture);
			this.Container.Size = new System.Drawing.Size(800, 450);
			this.Container.SplitterDistance = 200;
			this.Container.SplitterIncrement = 100;
			this.Container.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.Location = new System.Drawing.Point(0, 120);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(198, 60);
			this.button3.TabIndex = 3;
			this.button3.Text = "Águia";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.Location = new System.Drawing.Point(0, 60);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(198, 60);
			this.button1.TabIndex = 2;
			this.button1.Text = "Peixe";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(198, 60);
			this.button2.TabIndex = 1;
			this.button2.Text = "Logo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// picture
			// 
			this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picture.Location = new System.Drawing.Point(0, 0);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(594, 448);
			this.picture.TabIndex = 0;
			this.picture.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Container);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Container.Panel1.ResumeLayout(false);
			this.Container.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container)).EndInit();
			this.Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer Container;
		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

