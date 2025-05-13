using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacBiblioteca
{
    public partial class Atividade : Form
    {
        public Atividade()
        {
            InitializeComponent();
        }

        private void btnEmprestando_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emprestando emprestando = new Emprestando();
            emprestando.ShowDialog();
            this.Show();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Show();
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Livros livros = new Livros();
            livros.ShowDialog();    
            this.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funcionario funcionario = new Funcionario();
            funcionario.ShowDialog();
            this.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario usuario = new Usuario();
            usuario.ShowDialog();   
            this.Show();
        }

       
    }
}
