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
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(279, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Segunda Form";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPrincipal
			// 
			this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrincipal.Location = new System.Drawing.Point(13, 375);
			this.btnPrincipal.Name = "btnPrincipal";
			this.btnPrincipal.Size = new System.Drawing.Size(176, 63);
			this.btnPrincipal.TabIndex = 1;
			this.btnPrincipal.Text = "Principal";
			this.btnPrincipal.UseVisualStyleBackColor = true;
			this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
			// 
			// FormSegundo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnPrincipal);
			this.Controls.Add(this.label1);
			this.Name = "FormSegundo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FormSegundo_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPrincipal;
	}
}