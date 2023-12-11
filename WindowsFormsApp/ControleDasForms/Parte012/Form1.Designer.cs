namespace Parte012
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
			monthCalendar1 = new MonthCalendar();
			button1 = new Button();
			SuspendLayout();
			// 
			// monthCalendar1
			// 
			monthCalendar1.Location = new Point(18, 18);
			monthCalendar1.MaxDate = new DateTime(2025, 6, 15, 0, 0, 0, 0);
			monthCalendar1.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.SelectionRange = new SelectionRange(new DateTime(2023, 12, 14, 0, 0, 0, 0), new DateTime(2023, 12, 20, 0, 0, 0, 0));
			monthCalendar1.TabIndex = 0;
			monthCalendar1.TodayDate = new DateTime(2023, 7, 9, 0, 0, 0, 0);
			monthCalendar1.DateChanged += monthCalendar1_DateChanged;
			// 
			// button1
			// 
			button1.Location = new Point(18, 205);
			button1.Name = "button1";
			button1.Size = new Size(227, 60);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(monthCalendar1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private MonthCalendar monthCalendar1;
		private Button button1;
	}
}