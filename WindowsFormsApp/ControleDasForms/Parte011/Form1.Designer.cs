namespace Parte011
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			maskedTextBox1 = new MaskedTextBox();
			SuspendLayout();
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
			maskedTextBox1.Location = new Point(52, 39);
			maskedTextBox1.Mask = "(00) 0 0000-0000";
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(423, 50);
			maskedTextBox1.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(maskedTextBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MaskedTextBox maskedTextBox1;
	}
}