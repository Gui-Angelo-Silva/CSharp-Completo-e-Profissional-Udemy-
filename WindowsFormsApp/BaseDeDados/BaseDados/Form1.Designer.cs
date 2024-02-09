namespace BaseDados
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
			this.lblResultado = new System.Windows.Forms.Label();
			this.lista = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btnConectar = new System.Windows.Forms.Button();
			this.btnCriarTabela = new System.Windows.Forms.Button();
			this.btnInserir = new System.Windows.Forms.Button();
			this.btnProcurar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
			this.SuspendLayout();
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(13, 13);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(609, 90);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.Text = "Resultado";
			// 
			// lista
			// 
			this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.lista.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.email});
			this.lista.Location = new System.Drawing.Point(12, 230);
			this.lista.MultiSelect = false;
			this.lista.Name = "lista";
			this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.lista.Size = new System.Drawing.Size(610, 303);
			this.lista.TabIndex = 1;
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			// 
			// nome
			// 
			this.nome.HeaderText = "NOME";
			this.nome.Name = "nome";
			// 
			// email
			// 
			this.email.HeaderText = "E-MAIL";
			this.email.Name = "email";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = "Email";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(120, 113);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(502, 35);
			this.txtNome.TabIndex = 4;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(120, 172);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(502, 35);
			this.txtEmail.TabIndex = 5;
			// 
			// btnConectar
			// 
			this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConectar.Location = new System.Drawing.Point(629, 113);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(159, 65);
			this.btnConectar.TabIndex = 6;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// btnCriarTabela
			// 
			this.btnCriarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCriarTabela.Location = new System.Drawing.Point(629, 184);
			this.btnCriarTabela.Name = "btnCriarTabela";
			this.btnCriarTabela.Size = new System.Drawing.Size(159, 65);
			this.btnCriarTabela.TabIndex = 7;
			this.btnCriarTabela.Text = "Cirar Tabela";
			this.btnCriarTabela.UseVisualStyleBackColor = true;
			this.btnCriarTabela.Click += new System.EventHandler(this.btnCriarTabela_Click);
			// 
			// btnInserir
			// 
			this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserir.Location = new System.Drawing.Point(629, 255);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(159, 65);
			this.btnInserir.TabIndex = 8;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// btnProcurar
			// 
			this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcurar.Location = new System.Drawing.Point(629, 326);
			this.btnProcurar.Name = "btnProcurar";
			this.btnProcurar.Size = new System.Drawing.Size(159, 65);
			this.btnProcurar.TabIndex = 9;
			this.btnProcurar.Text = "Procurar";
			this.btnProcurar.UseVisualStyleBackColor = true;
			this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(629, 397);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(159, 65);
			this.btnExcluir.TabIndex = 10;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(628, 468);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(159, 65);
			this.btnEditar.TabIndex = 11;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 544);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnProcurar);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.btnCriarTabela);
			this.Controls.Add(this.btnConectar);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lista);
			this.Controls.Add(this.lblResultado);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.DataGridView lista;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn email;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.Button btnCriarTabela;
		private System.Windows.Forms.Button btnInserir;
		private System.Windows.Forms.Button btnProcurar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnEditar;
	}
}

