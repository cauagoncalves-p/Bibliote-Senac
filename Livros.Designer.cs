namespace SenacBiblioteca
{
    partial class Livros
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
            this.txtTituto = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblIdLivro = new System.Windows.Forms.Label();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtISNB = new System.Windows.Forms.TextBox();
            this.lblISNB = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidadeDisponivel = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lboLivros = new System.Windows.Forms.ListBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTituto
            // 
            this.txtTituto.Location = new System.Drawing.Point(145, 52);
            this.txtTituto.Name = "txtTituto";
            this.txtTituto.Size = new System.Drawing.Size(100, 20);
            this.txtTituto.TabIndex = 3;
           
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(142, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(16, 186);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(13, 160);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Gênero";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(143, 186);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 7;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(140, 160);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 6;
            this.lblAutor.Text = "Autor";
            // 
            // lblIdLivro
            // 
            this.lblIdLivro.AutoSize = true;
            this.lblIdLivro.Location = new System.Drawing.Point(13, 26);
            this.lblIdLivro.Name = "lblIdLivro";
            this.lblIdLivro.Size = new System.Drawing.Size(45, 13);
            this.lblIdLivro.TabIndex = 0;
            this.lblIdLivro.Text = "Id Livro ";
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Enabled = false;
            this.txtIdLivro.Location = new System.Drawing.Point(16, 52);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(100, 20);
            this.txtIdLivro.TabIndex = 1;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(16, 121);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(100, 20);
            this.txtEditora.TabIndex = 9;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(13, 95);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(40, 13);
            this.lblEditora.TabIndex = 8;
            this.lblEditora.Text = "Editora";
            // 
            // txtISNB
            // 
            this.txtISNB.Location = new System.Drawing.Point(145, 121);
            this.txtISNB.Name = "txtISNB";
            this.txtISNB.Size = new System.Drawing.Size(100, 20);
            this.txtISNB.TabIndex = 11;
            // 
            // lblISNB
            // 
            this.lblISNB.AutoSize = true;
            this.lblISNB.Location = new System.Drawing.Point(142, 95);
            this.lblISNB.Name = "lblISNB";
            this.lblISNB.Size = new System.Drawing.Size(32, 13);
            this.lblISNB.TabIndex = 10;
            this.lblISNB.Text = "ISNB";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(16, 255);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(112, 20);
            this.txtQuantidade.TabIndex = 13;
            // 
            // lblQuantidadeDisponivel
            // 
            this.lblQuantidadeDisponivel.AutoSize = true;
            this.lblQuantidadeDisponivel.Location = new System.Drawing.Point(13, 229);
            this.lblQuantidadeDisponivel.Name = "lblQuantidadeDisponivel";
            this.lblQuantidadeDisponivel.Size = new System.Drawing.Size(115, 13);
            this.lblQuantidadeDisponivel.TabIndex = 12;
            this.lblQuantidadeDisponivel.Text = "Quantidade disponivel ";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Location = new System.Drawing.Point(143, 255);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(112, 20);
            this.txtDataCadastro.TabIndex = 15;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(140, 229);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(89, 13);
            this.lblDataCadastro.TabIndex = 14;
            this.lblDataCadastro.Text = "Data de cadastro";
            // 
            // lboLivros
            // 
            this.lboLivros.FormattingEnabled = true;
            this.lboLivros.Location = new System.Drawing.Point(289, 13);
            this.lboLivros.Name = "lboLivros";
            this.lboLivros.Size = new System.Drawing.Size(248, 420);
            this.lboLivros.TabIndex = 16;
            this.lboLivros.SelectedValueChanged += new System.EventHandler(this.lboLivros_SelectedValueChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(16, 319);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(180, 319);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(97, 319);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lboLivros);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidadeDisponivel);
            this.Controls.Add(this.txtISNB);
            this.Controls.Add(this.lblISNB);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtTituto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.lblIdLivro);
            this.Name = "Livros";
            this.Text = "Livros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTituto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblIdLivro;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtISNB;
        private System.Windows.Forms.Label lblISNB;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidadeDisponivel;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.ListBox lboLivros;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
    }
}