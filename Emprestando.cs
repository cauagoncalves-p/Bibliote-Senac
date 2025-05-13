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

namespace SenacBiblioteca
{
    public partial class Emprestando : Form
    {
        private LivrosTableAdapter livros;
        private FuncionariosTableAdapter funcionarios;
        private UsuariosTableAdapter usuarios;
        public Emprestando()
        {
            InitializeComponent();
            livros = new LivrosTableAdapter();
            var dados = from linha in livros.GetData()
                        select linha;
            foreach (var dado in dados)
            {
                string livros = dado.LivroID.ToString() + ";";
                livros +=  dado.Titulo;
                cboLivro.Items.Add(livros);
            }
            funcionarios = new FuncionariosTableAdapter();
            var dados1 = from linha in funcionarios.GetData()
                         select linha;
            foreach (var dado in dados1)
            {
                string funcionarios = dado.FuncionarioID.ToString() + ";";
                funcionarios += dado.NomeCompleto;
                cboFuncionario.Items.Add(funcionarios);
            }
            usuarios = new UsuariosTableAdapter();
            var dados2 = from linha in usuarios.GetData()
                         select linha;
            foreach (var dado in dados2)
            {
                string usuarios = dado.UsuarioID.ToString() + ";";
                usuarios += dado.Nome;
                cboUsuario.Items.Add(usuarios);
            }
            cboStatus.Items.AddRange(new String[] { "Aprovada", "Devolvido", "Pendente" });
            cboStatus.SelectedIndex = 0;
            cboUsuario.SelectedIndex = 0;
            cboFuncionario.SelectedIndex = 0;
            cboLivro.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmprestando_Click(object sender, EventArgs e)
        {
            string[] funcionarios = cboFuncionario.SelectedItem.ToString().Split(';');
            int funcionarioID = int.Parse(funcionarios[0]);
            string[] usuarios = cboUsuario.SelectedItem.ToString().Split(';');
            int usuarioID = int.Parse(usuarios[0]);
            string[] livros = cboLivro.SelectedItem.ToString().Split(';');
            int livroID = int.Parse(livros[0]);

            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            DateTime requisicao = dtpDevolucao.Value;
            DateTime devolucao = dtpDevolucao.Value;
            string status = cboStatus.SelectedItem.ToString();
            requisicoes.Insert(usuarioID,livroID,funcionarioID,requisicao,devolucao,status);
            this.Close();
        }
    }
}
