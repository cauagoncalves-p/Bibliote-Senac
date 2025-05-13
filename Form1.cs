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
    public partial class Form1 : Form
    {
        private void atualizarLista()
        {
            lboRelacao.Items.Clear();

            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            var dados = from linha in requisicoes.GetData()
                        select linha;
            foreach (var dado in dados)
            {
                string texto = dado.RequisicaoID.ToString();
                LivrosTableAdapter livros = new LivrosTableAdapter();
                LivrosRow livro = (from linha in livros.GetData()
                                   where linha.LivroID == dado.LivroID
                                   select linha).FirstOrDefault();
                if (livro == null) break;
                //texto = texto + " - " + livro.Titulo;
                texto += " ; " + livro.Titulo;
                FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                FuncionariosRow funcionario = (from linha in funcionarios.GetData()
                                               where linha.FuncionarioID == dado.FuncionarioID
                                               select linha).FirstOrDefault();
                if (funcionario == null) break;
                texto += " ; " + funcionario.NomeCompleto;
                UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                UsuariosRow usuario = (from linha in usuarios.GetData()
                                       where linha.UsuarioID == dado.UsuarioID
                                       select linha).FirstOrDefault();
                if (usuarios == null) break;
                texto += " ; " + usuario.Nome;

                lboRelacao.Items.Add(texto);

            }
        }
        public Form1()
        {
            InitializeComponent();
            atualizarLista();
        }

        private void lboRelacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboRelacao.SelectedItem == null) return;
            string[] dado = lboRelacao.SelectedItem.ToString().Split(';');
            int ID = int.Parse(dado[0]);
            // MessageBox.Show("ID: " + ID.ToString());
            Relacao relacao = new Relacao(ID);
            relacao.Closed += fechandoEsteFormulario;
            relacao.Show();
            this.Hide();

        }
        private void fechandoEsteFormulario(object sender, EventArgs e)
        {
            // Fechar o formulário atual
            this.Show();
            atualizarLista();

        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            Emprestando emprestando = new Emprestando();
            emprestando.Closed += fechandoEsteFormulario;
            emprestando.ShowDialog();
        }

        private void txtLivro_TextChanged(object sender, EventArgs e)
        {
            if (txtLivro.Text == "")
            {
                atualizarLista();
                return;
            }
            lboRelacao.Items.Clear();
            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            var dados = from linha in requisicoes.GetData()
                        select linha;
            foreach (var dado in dados)
            {
                string texto = dado.RequisicaoID.ToString();
                LivrosTableAdapter livros = new LivrosTableAdapter();
                LivrosRow livro = (from linha in livros.GetData()
                                   where linha.LivroID == dado.LivroID
                     && linha.Titulo.ToLower().Contains(txtLivro.Text.ToLower())
                                   select linha).FirstOrDefault();
                if (livro == null) continue;
                texto += " ; " + livro.Titulo;
                FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                FuncionariosRow funcionario = (from linha in funcionarios.GetData()
                                               where linha.FuncionarioID == dado.FuncionarioID
                                               select linha).FirstOrDefault();
                if (funcionario == null) break;
                texto += " ; " + funcionario.NomeCompleto;
                UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                UsuariosRow usuario = (from linha in usuarios.GetData()
                                       where linha.UsuarioID == dado.UsuarioID
                                       select linha).FirstOrDefault();
                if (usuarios == null) break;
                texto += " ; " + usuario.Nome;
                lboRelacao.Items.Add(texto);
            }
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (txtFuncionario.Text == "")
            {
                atualizarLista();
                return;
            }
            lboRelacao.Items.Clear();
            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            var dados = from linha in requisicoes.GetData()
                        select linha;
            foreach (var dado in dados)
            {
                string texto = dado.RequisicaoID.ToString();
                FuncionariosTableAdapter  funcionarios = new FuncionariosTableAdapter();
                FuncionariosRow funcionario = (from linha in funcionarios.GetData()
                                   where linha.FuncionarioID == dado.FuncionarioID
                     && linha.NomeCompleto.ToLower().Contains(txtFuncionario.Text.ToLower())
                                   select linha).FirstOrDefault();
                if (funcionario == null) continue;
                texto += " ; " + funcionario.NomeCompleto;
                lboRelacao.Items.Add(texto);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                atualizarLista();
                return;
            }

            lboRelacao.Items.Clear();
            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            var dados = from linha in requisicoes.GetData()
                        select linha;
            foreach (var dado in dados)
            {
                string texto = dado.RequisicaoID.ToString();
                UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                UsuariosRow usuario = (from linha in usuarios.GetData()
                                               where linha.UsuarioID == dado.UsuarioID
                                 && linha.Nome.ToLower().Contains(txtUsuario.Text.ToLower())
                                               select linha).FirstOrDefault();
                if (usuario == null) continue;
                texto += " ; " + usuario.Nome;
                lboRelacao.Items.Add(texto);
            }
        }
    }
}
