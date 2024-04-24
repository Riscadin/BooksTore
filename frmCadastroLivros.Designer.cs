namespace BooksTore
{
    partial class frmCadastroLivros
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
            this.txtBuscarLivros = new System.Windows.Forms.TextBox();
            this.btnBuscarLivros = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msktAno = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBuscarLivros
            // 
            this.txtBuscarLivros.Location = new System.Drawing.Point(57, 22);
            this.txtBuscarLivros.Name = "txtBuscarLivros";
            this.txtBuscarLivros.Size = new System.Drawing.Size(121, 20);
            this.txtBuscarLivros.TabIndex = 0;
            // 
            // btnBuscarLivros
            // 
            this.btnBuscarLivros.Location = new System.Drawing.Point(195, 22);
            this.btnBuscarLivros.Name = "btnBuscarLivros";
            this.btnBuscarLivros.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLivros.TabIndex = 1;
            this.btnBuscarLivros.Text = "Buscar Livro";
            this.btnBuscarLivros.UseVisualStyleBackColor = true;
            this.btnBuscarLivros.Click += new System.EventHandler(this.btnBuscarLivros_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(57, 116);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(57, 158);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(121, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ano";
            // 
            // msktAno
            // 
            this.msktAno.Location = new System.Drawing.Point(57, 197);
            this.msktAno.Mask = "00/00/0000";
            this.msktAno.Name = "msktAno";
            this.msktAno.ReadOnly = true;
            this.msktAno.Size = new System.Drawing.Size(121, 20);
            this.msktAno.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cadastrar Novo Livro";
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.Location = new System.Drawing.Point(57, 245);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(121, 32);
            this.btnSalvarLivro.TabIndex = 12;
            this.btnSalvarLivro.Text = "Salvar Livro";
            this.btnSalvarLivro.UseVisualStyleBackColor = true;
            this.btnSalvarLivro.Click += new System.EventHandler(this.btnSalvarLivro_Click);
            // 
            // frmCadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 298);
            this.Controls.Add(this.btnSalvarLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msktAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnBuscarLivros);
            this.Controls.Add(this.txtBuscarLivros);
            this.Name = "frmCadastroLivros";
            this.Text = "Cadastro e Busca de Livros";
            this.Load += new System.EventHandler(this.frmCadastroLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarLivros;
        private System.Windows.Forms.Button btnBuscarLivros;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvarLivro;
    }
}