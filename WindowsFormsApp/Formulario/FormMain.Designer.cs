namespace Formulario
{
	partial class FormMain
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnSegundo = new System.Windows.Forms.Button();
			this.btnSegundoFormThread = new System.Windows.Forms.Button();
			this.menuBar = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mFileNovo = new System.Windows.Forms.ToolStripMenuItem();
			this.mFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mFileSair = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
			this.mHelpSobreDev = new System.Windows.Forms.ToolStripMenuItem();
			this.mHelpSobreVersao = new System.Windows.Forms.ToolStripMenuItem();
			this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
			this.mPesquisar = new System.Windows.Forms.ToolStripTextBox();
			this.menuBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(16, 80);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(768, 103);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Principal";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSegundo
			// 
			this.btnSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSegundo.Location = new System.Drawing.Point(20, 385);
			this.btnSegundo.Name = "btnSegundo";
			this.btnSegundo.Size = new System.Drawing.Size(195, 53);
			this.btnSegundo.TabIndex = 1;
			this.btnSegundo.Text = "Segundo Form";
			this.btnSegundo.UseVisualStyleBackColor = true;
			this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
			// 
			// btnSegundoFormThread
			// 
			this.btnSegundoFormThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSegundoFormThread.Location = new System.Drawing.Point(221, 385);
			this.btnSegundoFormThread.Name = "btnSegundoFormThread";
			this.btnSegundoFormThread.Size = new System.Drawing.Size(243, 53);
			this.btnSegundoFormThread.TabIndex = 2;
			this.btnSegundoFormThread.Text = "Segundo Form Thread";
			this.btnSegundoFormThread.UseVisualStyleBackColor = true;
			this.btnSegundoFormThread.Click += new System.EventHandler(this.btnSegundoFormThread_Click);
			// 
			// menuBar
			// 
			this.menuBar.BackColor = System.Drawing.SystemColors.Control;
			this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.comboMenu,
            this.mPesquisar});
			this.menuBar.Location = new System.Drawing.Point(0, 0);
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new System.Drawing.Size(800, 27);
			this.menuBar.TabIndex = 3;
			this.menuBar.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNovo,
            this.mFileAbrir,
            this.toolStripSeparator1,
            this.mFileSair});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 23);
			this.menuFile.Text = "File";
			// 
			// mFileNovo
			// 
			this.mFileNovo.Name = "mFileNovo";
			this.mFileNovo.Size = new System.Drawing.Size(180, 22);
			this.mFileNovo.Text = "Novo";
			this.mFileNovo.Click += new System.EventHandler(this.mFileNovo_Click);
			// 
			// mFileAbrir
			// 
			this.mFileAbrir.Name = "mFileAbrir";
			this.mFileAbrir.Size = new System.Drawing.Size(180, 22);
			this.mFileAbrir.Text = "Abrir";
			this.mFileAbrir.Click += new System.EventHandler(this.mFileAbrir_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// mFileSair
			// 
			this.mFileSair.Name = "mFileSair";
			this.mFileSair.Size = new System.Drawing.Size(180, 22);
			this.mFileSair.Text = "Sair";
			this.mFileSair.Click += new System.EventHandler(this.mFileSair_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobre});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(44, 23);
			this.menuHelp.Text = "Help";
			// 
			// mHelpSobre
			// 
			this.mHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobreDev,
            this.mHelpSobreVersao});
			this.mHelpSobre.Name = "mHelpSobre";
			this.mHelpSobre.Size = new System.Drawing.Size(180, 22);
			this.mHelpSobre.Text = "Sobre";
			// 
			// mHelpSobreDev
			// 
			this.mHelpSobreDev.Name = "mHelpSobreDev";
			this.mHelpSobreDev.Size = new System.Drawing.Size(180, 22);
			this.mHelpSobreDev.Text = "Desenvolvedor";
			this.mHelpSobreDev.Click += new System.EventHandler(this.mHelpSobreDev_Click);
			// 
			// mHelpSobreVersao
			// 
			this.mHelpSobreVersao.Name = "mHelpSobreVersao";
			this.mHelpSobreVersao.Size = new System.Drawing.Size(180, 22);
			this.mHelpSobreVersao.Text = "Versão";
			this.mHelpSobreVersao.Click += new System.EventHandler(this.mHelpSobreVersao_Click);
			// 
			// comboMenu
			// 
			this.comboMenu.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
			this.comboMenu.Name = "comboMenu";
			this.comboMenu.Size = new System.Drawing.Size(121, 23);
			this.comboMenu.SelectedIndexChanged += new System.EventHandler(this.comboMenu_SelectedIndexChanged);
			// 
			// mPesquisar
			// 
			this.mPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.mPesquisar.Name = "mPesquisar";
			this.mPesquisar.Size = new System.Drawing.Size(200, 23);
			this.mPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mPesquisar_KeyUp);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSegundoFormThread);
			this.Controls.Add(this.btnSegundo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.menuBar);
			this.MainMenuStrip = this.menuBar;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formulario Principal";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuBar.ResumeLayout(false);
			this.menuBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button btnSegundo;
		private System.Windows.Forms.Button btnSegundoFormThread;
		private System.Windows.Forms.MenuStrip menuBar;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem mFileNovo;
		private System.Windows.Forms.ToolStripMenuItem mFileAbrir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mFileSair;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem mHelpSobre;
		private System.Windows.Forms.ToolStripMenuItem mHelpSobreDev;
		private System.Windows.Forms.ToolStripMenuItem mHelpSobreVersao;
		private System.Windows.Forms.ToolStripComboBox comboMenu;
		private System.Windows.Forms.ToolStripTextBox mPesquisar;
	}
}

