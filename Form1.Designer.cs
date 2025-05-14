namespace SenacBiblioteca
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
            this.lboRelacao = new System.Windows.Forms.ListBox();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblLivro = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboRelacao
            // 
            this.lboRelacao.FormattingEnabled = true;
            this.lboRelacao.Location = new System.Drawing.Point(272, 12);
            this.lboRelacao.Name = "lboRelacao";
            this.lboRelacao.Size = new System.Drawing.Size(267, 407);
            this.lboRelacao.TabIndex = 0;
            this.lboRelacao.SelectedIndexChanged += new System.EventHandler(this.lboRelacao_SelectedIndexChanged);
            // 
            // txtLivro
            // 
            this.txtLivro.Location = new System.Drawing.Point(13, 39);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(100, 20);
            this.txtLivro.TabIndex = 1;
            this.txtLivro.TextChanged += new System.EventHandler(this.txtLivro_TextChanged);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(13, 98);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtFuncionario.TabIndex = 2;
            this.txtFuncionario.TextChanged += new System.EventHandler(this.txtFuncionario_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(13, 160);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(13, 20);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(30, 13);
            this.lblLivro.TabIndex = 4;
            this.lblLivro.Text = "Livro";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(13, 79);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 5;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(13, 144);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuário";
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(16, 222);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(128, 37);
            this.btnEmprestar.TabIndex = 7;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.Location = new System.Drawing.Point(12, 295);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(73, 24);
            this.btnLivro.TabIndex = 8;
            this.btnLivro.Text = "Livro";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(93, 295);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(73, 24);
            this.btnFuncionario.TabIndex = 9;
            this.btnFuncionario.Text = "Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(180, 295);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(73, 24);
            this.btnUsuario.TabIndex = 10;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnLivro);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.lboRelacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboRelacao;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnUsuario;
    }
}

