using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenacBiblioteca.BibliotecaDBDataSetTableAdapters;
using static SenacBiblioteca.BibliotecaDBDataSet;

namespace SenacBiblioteca
{
    public partial class Relacao : Form
    {
        private RequisicoesRow requisicao;
        private RequisicoesTableAdapter requisicoes;
        private LivrosRow livro;
        private LivrosTableAdapter livros;
        private UsuariosRow usuario;
        private UsuariosTableAdapter usuarios;
        private FuncionariosRow funcionario;
        private FuncionariosTableAdapter funcionarios;
        public Relacao(int ID)
        {
            InitializeComponent();
            cboStatus.Items.Add("Devolvido");
            cboStatus.Items.Add("Aprovada");
            cboStatus.Items.Add("Pendente");
            requisicoes = new RequisicoesTableAdapter();
            requisicao = (from linha in requisicoes.GetData()
                                         where linha.RequisicaoID == ID
                                         select linha).FirstOrDefault();
            if (requisicao == null) return;
            cboStatus.SelectedItem = requisicao.Status;
            try
            {
                dtpRequisicaoDevolucao.Value = requisicao.DataDevolucao;
            }
            catch (Exception)
            {
                dtpRequisicaoDevolucao.Value = DateTime.Now;
            }
            try
            {
                dtpRequisicaoRequisitado.Value = requisicao.DataRequisicao;
            }
            catch
            {
                dtpRequisicaoRequisitado.Value = DateTime.Now;
            }
            livros = new LivrosTableAdapter();
            livro = (from linha in livros.GetData()
                               where linha.LivroID == requisicao.LivroID
                               select linha).FirstOrDefault();
            if (livro == null) return;
            txtLivroNome.Text = livro.Titulo;
            txtLivroQuantidade.Text = livro.QuantidadeDisponivel.ToString();
            funcionarios = new FuncionariosTableAdapter();
            funcionario = (from linha in funcionarios.GetData()
                                           where requisicao.FuncionarioID == linha.FuncionarioID
                                           select linha).FirstOrDefault();
            if(funcionario == null) return;
            txtFuncionarioNome.Text = funcionario.NomeCompleto;
            txtFuncionarioCargo.Text = funcionario.Cargo;
            try
            {
                dtpFuncionarioLogin.Value = funcionario.UltimoLogin;
            }
            catch
            {
                dtpFuncionarioLogin.Value = DateTime.Now;
            }
            usuarios = new UsuariosTableAdapter();
            usuario = (from linha in usuarios.GetData()
                                   where requisicao.UsuarioID == linha.UsuarioID
                                   select linha).FirstOrDefault();
            if (usuario == null) return;
            txtUsuarioNome.Text = usuario.Nome;
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            funcionario.UltimoLogin = DateTime.Now;
            funcionarios.Update(funcionario);
            if (requisicao.Status == "Devolvido")
            {
                if (requisicao.Status != "Devolvido")
                    livro.QuantidadeDisponivel++;
                requisicao.DataDevolucao = dtpRequisicaoDevolucao.Value;
                requisicao.DataRequisicao = dtpRequisicaoRequisitado.Value;
                requisicao.Status = cboStatus.SelectedItem as string;
                livros.Update(livro);
                requisicoes.Update(requisicao);
                this.Close();

            }
            else if (cboStatus.Text == "Aprovada")
            {
                if (requisicao.Status != "Aprovada")
                    livro.QuantidadeDisponivel--;
                requisicao.DataDevolucao = dtpRequisicaoDevolucao.Value;
                requisicao.DataRequisicao = dtpRequisicaoRequisitado.Value;
                requisicao.Status = cboStatus.SelectedItem as string;
                livros.Update(livro);
                requisicoes.Update(requisicao);
                this.Close();
            }
            else
            {
                if (requisicao.Status != "Pendente")
                    livro.QuantidadeDisponivel--;
                requisicao.DataDevolucao = dtpRequisicaoDevolucao.Value;
                requisicao.DataRequisicao = dtpRequisicaoRequisitado.Value;
                requisicao.Status = cboStatus.SelectedItem as string;
                livros.Update(livro);
                requisicoes.Update(requisicao);
                this.Close();
            }
        }
    }
}
