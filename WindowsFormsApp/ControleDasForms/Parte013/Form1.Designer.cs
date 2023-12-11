namespace Parte013
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
			numericUpDown1 = new NumericUpDown();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// numericUpDown1
			// 
			numericUpDown1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
			numericUpDown1.ForeColor = SystemColors.HotTrack;
			numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 0 });
			numericUpDown1.Location = new Point(279, 241);
			numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
			numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(268, 50);
			numericUpDown1.TabIndex = 0;
			numericUpDown1.TextAlign = HorizontalAlignment.Center;
			numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(347, 80);
			label1.Name = "label1";
			label1.Size = new Size(128, 50);
			label1.TabIndex = 1;
			label1.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label1);
			Controls.Add(numericUpDown1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown numericUpDown1;
		private Label label1;
	}
}