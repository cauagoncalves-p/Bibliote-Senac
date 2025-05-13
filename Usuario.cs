using SenacBiblioteca.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SenacBiblioteca.BibliotecaDBDataSet;

namespace SenacBiblioteca
{
    public partial class Usuario : Form
    {
        private void AtualizaraBanco()
        {
            lboUsuario.Items.Clear();
            UsuariosTableAdapter livros = new UsuariosTableAdapter();
            var dados = from linha in livros.GetData() select linha;

            foreach (var dado in dados)
            {
                lboUsuario.Items.Add(dado);
            }
        }

        private void LimparCampos()
        {
            txtIdUsuario.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtDataCadastro.Clear();
            txtEmail.Clear();
            txtDataCadastro.Clear();
        }
        public Usuario()
        {
            InitializeComponent();
            AtualizaraBanco();
        }

        private void lboUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lboUsuario.SelectedItem == null)
            {
                return;
            }

            UsuariosRow usuario = lboUsuario.SelectedItem as UsuariosRow;

            txtIdUsuario.Text = usuario.UsuarioID.ToString();
            txtNome.Text = usuario.Nome;
            txtDataCadastro.Text = usuario.DataCadastro.ToString();
            txtEmail.Text = usuario.Email;
            txtTelefone.Text = usuario.Telefone;
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (lboUsuario.SelectedItem == null)
            {
                MessageBox.Show("Selecione qual elemento você quer atualizar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            UsuariosRow dadosAtualizar = lboUsuario.SelectedItem as UsuariosRow;
            UsuariosTableAdapter atualizar = new UsuariosTableAdapter();

            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            DateTime cadastro = DateTime.Now;

            // Atualizando os dados 
            dadosAtualizar.Nome = nome;
            dadosAtualizar.Email = email;
            dadosAtualizar.Telefone = telefone;
            dadosAtualizar.DataCadastro = cadastro;
            atualizar.Update(dadosAtualizar);

            AtualizaraBanco();
            LimparCampos();

            MessageBox.Show("Atualizado com sucesso", "Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

       
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (lboUsuario.Items == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();

            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
          
            DateTime cadastro = DateTime.Now;
            usuarios.Insert(nome, email,telefone, cadastro);
            AtualizaraBanco();

            MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
