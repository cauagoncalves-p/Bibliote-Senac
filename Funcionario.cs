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
    public partial class Funcionario : Form
    {
        private void AtualizaraBanco()
        {
            lboFuncionarios.Items.Clear();
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var dados = from linha in funcionarios.GetData() select linha;

            foreach (var dado in dados)
            {
                lboFuncionarios.Items.Add(dado);
            }
        }

        private void LimparCampos()
        {
            txtIdFuncionario.Clear();
            txtNomeCompleto.Clear();
            txtNomeUsuario.Clear();
            txtDataCadastro.Clear();
            txtEmail.Clear();
            txtUltimoLogin.Clear();
            txtCargo.Clear();
            txtSenha.Clear();
            txtAtivo.Clear();
        }
        public Funcionario()
        {
            InitializeComponent();
            AtualizaraBanco();
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            int? funcionarioSelecionadoID = null;
            if (lboFuncionarios.SelectedItem is FuncionariosRow funcionarioSelecionado)
            {
                funcionarioSelecionadoID = funcionarioSelecionado.FuncionarioID;
            }

            if (txtNomeUsuario.Text == "")
            {
                AtualizaraBanco();
                return;
            }

            lboFuncionarios.Items.Clear();
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var dados = from linha in funcionarios.GetData()
                        select linha;
            foreach (var dado in dados)
            {
                string texto = dado.FuncionarioID.ToString();
                FuncionariosRow funcionario = (from linha in funcionarios.GetData()
                                       where linha.FuncionarioID == dado.FuncionarioID
                         && linha.NomeUsuario.ToLower().Contains(txtNomeUsuario.Text.ToLower())
                                       select linha).FirstOrDefault();
                if (funcionario == null) continue;
                texto += " - " + funcionario.NomeUsuario;
                lboFuncionarios.Items.Add(funcionario);
            }

            if (funcionarioSelecionadoID.HasValue)
            {
                foreach (FuncionariosRow item in lboFuncionarios.Items)
                {
                    if (item.FuncionarioID == funcionarioSelecionadoID.Value)
                    {
                        lboFuncionarios.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (lboFuncionarios.Items == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtNomeUsuario.Text) || string.IsNullOrEmpty(txtNomeCompleto.Text) || string.IsNullOrEmpty(txtSenha.Text)
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCargo.Text) || string.IsNullOrEmpty(txtAtivo.Text) )
            {
                MessageBox.Show("Por favor preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            FuncionariosTableAdapter funcionairos = new FuncionariosTableAdapter();

            string nomeUsuario = txtNomeUsuario.Text;
            string email = txtEmail.Text;
            string cargo = txtCargo.Text;
            string nomeCompleto = txtNomeCompleto.Text;
            string senha = txtSenha.Text;
            bool ativo = bool.Parse(txtAtivo.Text);
            DateTime ultimoLogin = DateTime.Now; 
            DateTime cadastro = DateTime.Now;
            funcionairos.Insert(nomeUsuario,senha,nomeCompleto,cargo,email,cadastro,ultimoLogin,ativo);
            AtualizaraBanco();

            MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void lboFuncionarios_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lboFuncionarios.SelectedItem == null) return;

            FuncionariosRow funcionarios = lboFuncionarios.SelectedItem as FuncionariosRow;

            txtIdFuncionario.Text = funcionarios.FuncionarioID.ToString();
            txtCargo.Text = funcionarios.Cargo;
            txtEmail.Text = funcionarios.Email;
            DateTime ultimoLogin = DateTime.Now;
            txtUltimoLogin.Text = ultimoLogin.ToString();
            txtNomeUsuario.Text = funcionarios.NomeUsuario;
            txtNomeCompleto.Text = funcionarios.NomeCompleto;
            txtSenha.Text = funcionarios.SenhaHash.ToString();
            txtAtivo.Text = funcionarios.Ativo.ToString();
            txtDataCadastro.Text = funcionarios.DataCadastro.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (lboFuncionarios.SelectedItem == null)
            {
                MessageBox.Show("Selecione qual elemento você quer atualizar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            FuncionariosRow dadosAtualizar = lboFuncionarios.SelectedItem as FuncionariosRow;
            FuncionariosTableAdapter atualizar = new FuncionariosTableAdapter();

            string cargo = txtCargo.Text;
            string email = txtEmail.Text;
            DateTime ultimoLogin = Convert.ToDateTime(txtUltimoLogin.Text);
            string nomeUsuario = txtNomeUsuario.Text;
            string nomeCompleto = txtNomeCompleto.Text;  
            string senha = txtSenha.Text;
            bool ativo = Convert.ToBoolean(txtAtivo.Text);
            DateTime cadastro = DateTime.Now;

            // Atualizando os dados 
            dadosAtualizar.Cargo = cargo;
            dadosAtualizar.Email = email;
            dadosAtualizar.UltimoLogin = ultimoLogin;
            dadosAtualizar.DataCadastro = cadastro;
            dadosAtualizar.NomeUsuario = nomeUsuario;
            dadosAtualizar.NomeCompleto = nomeCompleto;
            dadosAtualizar.Ativo = ativo;
            dadosAtualizar.SenhaHash = senha;
            atualizar.Update(dadosAtualizar);

            AtualizaraBanco();
            LimparCampos();

            MessageBox.Show("Atualizado com sucesso", "Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}