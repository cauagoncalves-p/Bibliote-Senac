namespace SenacBiblioteca
{
    partial class Atividade
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
            this.btnEmprestando = new System.Windows.Forms.Button();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmprestando
            // 
            this.btnEmprestando.Location = new System.Drawing.Point(13, 36);
            this.btnEmprestando.Name = "btnEmprestando";
            this.btnEmprestando.Size = new System.Drawing.Size(131, 43);
            this.btnEmprestando.TabIndex = 0;
            this.btnEmprestando.Text = "Emprestar";
            this.btnEmprestando.UseVisualStyleBackColor = true;
            this.btnEmprestando.Click += new System.EventHandler(this.btnEmprestando_Click);
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(198, 36);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(131, 43);
            this.btnForm1.TabIndex = 1;
            this.btnForm1.Text = "Formulário 1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.Location = new System.Drawing.Point(378, 36);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(131, 43);
            this.btnLivro.TabIndex = 2;
            this.btnLivro.Text = "Livros";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(553, 36);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(131, 43);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "Funcionários";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(12, 121);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(131, 43);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Atividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnLivro);
            this.Controls.Add(this.btnForm1);
            this.Controls.Add(this.btnEmprestando);
            this.Name = "Atividade";
            this.Text = "Atividade";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmprestando;
        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnUsuario;
    }
}