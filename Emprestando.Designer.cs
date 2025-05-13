namespace SenacBiblioteca
{
    partial class Emprestando
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
            this.cboLivro = new System.Windows.Forms.ComboBox();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblLivro = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtpRequisicao = new System.Windows.Forms.DateTimePicker();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.lblRequisicao = new System.Windows.Forms.Label();
            this.btnEmprestando = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboLivro
            // 
            this.cboLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLivro.FormattingEnabled = true;
            this.cboLivro.Location = new System.Drawing.Point(35, 106);
            this.cboLivro.Name = "cboLivro";
            this.cboLivro.Size = new System.Drawing.Size(121, 21);
            this.cboLivro.TabIndex = 0;
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(206, 106);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cboFuncionario.TabIndex = 1;
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(384, 106);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(121, 21);
            this.cboUsuario.TabIndex = 2;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(35, 87);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(30, 13);
            this.lblLivro.TabIndex = 3;
            this.lblLivro.Text = "Livro";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(206, 86);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 4;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(384, 87);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(66, 193);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(417, 21);
            this.cboStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(63, 177);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Location = new System.Drawing.Point(66, 272);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(417, 20);
            this.dtpDevolucao.TabIndex = 8;
            // 
            // dtpRequisicao
            // 
            this.dtpRequisicao.Location = new System.Drawing.Point(66, 327);
            this.dtpRequisicao.Name = "dtpRequisicao";
            this.dtpRequisicao.Size = new System.Drawing.Size(417, 20);
            this.dtpRequisicao.TabIndex = 9;
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(66, 253);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(59, 13);
            this.lblDevolucao.TabIndex = 10;
            this.lblDevolucao.Text = "Devolução";
            // 
            // lblRequisicao
            // 
            this.lblRequisicao.AutoSize = true;
            this.lblRequisicao.Location = new System.Drawing.Point(66, 311);
            this.lblRequisicao.Name = "lblRequisicao";
            this.lblRequisicao.Size = new System.Drawing.Size(60, 13);
            this.lblRequisicao.TabIndex = 11;
            this.lblRequisicao.Text = "Requisição";
            // 
            // btnEmprestando
            // 
            this.btnEmprestando.Location = new System.Drawing.Point(66, 363);
            this.btnEmprestando.Name = "btnEmprestando";
            this.btnEmprestando.Size = new System.Drawing.Size(143, 23);
            this.btnEmprestando.TabIndex = 12;
            this.btnEmprestando.Text = "Emprestando";
            this.btnEmprestando.UseVisualStyleBackColor = true;
            this.btnEmprestando.Click += new System.EventHandler(this.btnEmprestando_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(340, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Emprestando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 420);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEmprestando);
            this.Controls.Add(this.lblRequisicao);
            this.Controls.Add(this.lblDevolucao);
            this.Controls.Add(this.dtpRequisicao);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.cboLivro);
            this.Name = "Emprestando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLivro;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.DateTimePicker dtpRequisicao;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.Label lblRequisicao;
        private System.Windows.Forms.Button btnEmprestando;
        private System.Windows.Forms.Button btnCancelar;
    }
}