namespace Parte015
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
			progress = new ProgressBar();
			btnExecutar = new Button();
			SuspendLayout();
			// 
			// progress
			// 
			progress.Location = new Point(98, 94);
			progress.MarqueeAnimationSpeed = 10;
			progress.Name = "progress";
			progress.Size = new Size(605, 72);
			progress.Style = ProgressBarStyle.Marquee;
			progress.TabIndex = 0;
			progress.Value = 75;
			// 
			// btnExecutar
			// 
			btnExecutar.Location = new Point(309, 329);
			btnExecutar.Name = "btnExecutar";
			btnExecutar.Size = new Size(183, 66);
			btnExecutar.TabIndex = 1;
			btnExecutar.Text = "Executar";
			btnExecutar.UseVisualStyleBackColor = true;
			btnExecutar.Click += btnExecutar_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnExecutar);
			Controls.Add(progress);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private ProgressBar progress;
		private Button btnExecutar;
	}
}