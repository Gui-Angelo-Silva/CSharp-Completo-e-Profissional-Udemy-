namespace CriptoStringMD5
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
			this.txtEntrada = new System.Windows.Forms.TextBox();
			this.txtSaida = new System.Windows.Forms.TextBox();
			this.btnCriptografar = new System.Windows.Forms.Button();
			this.btnComparar = new System.Windows.Forms.Button();
			this.labelResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtEntrada
			// 
			this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEntrada.Location = new System.Drawing.Point(13, 13);
			this.txtEntrada.Multiline = true;
			this.txtEntrada.Name = "txtEntrada";
			this.txtEntrada.Size = new System.Drawing.Size(775, 169);
			this.txtEntrada.TabIndex = 0;
			// 
			// txtSaida
			// 
			this.txtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaida.Location = new System.Drawing.Point(13, 188);
			this.txtSaida.Multiline = true;
			this.txtSaida.Name = "txtSaida";
			this.txtSaida.Size = new System.Drawing.Size(775, 169);
			this.txtSaida.TabIndex = 1;
			// 
			// btnCriptografar
			// 
			this.btnCriptografar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCriptografar.Location = new System.Drawing.Point(13, 364);
			this.btnCriptografar.Name = "btnCriptografar";
			this.btnCriptografar.Size = new System.Drawing.Size(380, 79);
			this.btnCriptografar.TabIndex = 2;
			this.btnCriptografar.Text = "Criptografar";
			this.btnCriptografar.UseVisualStyleBackColor = true;
			this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
			// 
			// btnComparar
			// 
			this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComparar.Location = new System.Drawing.Point(407, 364);
			this.btnComparar.Name = "btnComparar";
			this.btnComparar.Size = new System.Drawing.Size(381, 79);
			this.btnComparar.TabIndex = 3;
			this.btnComparar.Text = "Comparar";
			this.btnComparar.UseVisualStyleBackColor = true;
			this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
			// 
			// labelResultado
			// 
			this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResultado.Location = new System.Drawing.Point(13, 450);
			this.labelResultado.Name = "labelResultado";
			this.labelResultado.Size = new System.Drawing.Size(775, 150);
			this.labelResultado.TabIndex = 4;
			this.labelResultado.Text = "Resultado";
			this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 609);
			this.Controls.Add(this.labelResultado);
			this.Controls.Add(this.btnComparar);
			this.Controls.Add(this.btnCriptografar);
			this.Controls.Add(this.txtSaida);
			this.Controls.Add(this.txtEntrada);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEntrada;
		private System.Windows.Forms.TextBox txtSaida;
		private System.Windows.Forms.Button btnCriptografar;
		private System.Windows.Forms.Button btnComparar;
		private System.Windows.Forms.Label labelResultado;
	}
}

