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
using System.Xml;
using static SenacBiblioteca.BibliotecaDBDataSet;

namespace SenacBiblioteca
{
    public partial class Livros : Form
    {
      

        private void AtualizaraBanco() 
        {
            lboLivros.Items.Clear();
            LivrosTableAdapter livros = new LivrosTableAdapter();
            var dados = from linha in livros.GetData() select linha;

            foreach (var dado in dados) 
            {
                lboLivros.Items.Add(dado);  
            }
        }

        private void LimparCampos() 
        {
            txtIdLivro.Clear();
            txtTituto.Clear();
            txtQuantidade.Clear();  
            txtISNB.Clear();    
            txtGenero.Clear();
            txtDataCadastro.Clear();
            txtEditora.Clear();
            txtAutor.Clear();
        }


        public Livros()
        {
            InitializeComponent();
            AtualizaraBanco();
        }
        private void lboLivros_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lboLivros.SelectedItem == null) 
            {
                return;
            }
     
            LivrosRow livro = lboLivros.SelectedItem as LivrosRow;

            txtIdLivro.Text = livro.LivroID.ToString();
            txtTituto.Text = livro.Titulo.ToString();
            txtDataCadastro.Text = livro.DataCadastro.ToString();
            txtEditora.Text = livro.Editora ;
            txtISNB.Text = livro.ISBN ;
            txtGenero.Text = livro.Genero;
            txtQuantidade.Text = livro.QuantidadeDisponivel.ToString();
            txtAutor.Text = livro.Autor ;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();   
        }

    
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (lboLivros.Items == null) 
            {
                return;
            }

            if (string.IsNullOrEmpty(txtAutor.Text) || string.IsNullOrEmpty(txtTituto.Text) || string.IsNullOrEmpty(txtGenero.Text)
             || string.IsNullOrEmpty(txtQuantidade.Text) || string.IsNullOrEmpty(txtISNB.Text) || string.IsNullOrEmpty(txtEditora.Text)) 
            {
                MessageBox.Show("Por favor preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   
               

            LivrosTableAdapter livros = new LivrosTableAdapter();
           
            string titulo = txtTituto.Text;
            string autor = txtAutor.Text;
            string genero = txtGenero.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            string isnb = txtISNB.Text;
            string editora = txtEditora.Text;
            DateTime cadastro = DateTime.Now;
            livros.Insert(titulo, genero, autor, editora, isnb, quantidade, cadastro);
            AtualizaraBanco();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lboLivros.SelectedItem == null)
            {
                MessageBox.Show("Selecione qual elemento você quer atualizar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            LivrosRow dadosAtualizar = lboLivros.SelectedItem as LivrosRow;
            LivrosTableAdapter atualizar = new LivrosTableAdapter();

            string titulo = txtTituto.Text;
            string autor = txtAutor.Text;
            string genero = txtGenero.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            string isnb = txtISNB.Text;
            string editora = txtEditora.Text;
            DateTime cadastro = DateTime.Now;

            // Atualizando os dados 
            dadosAtualizar.Titulo = titulo;
            dadosAtualizar.Autor = autor;
            dadosAtualizar.Genero = genero;
            dadosAtualizar.QuantidadeDisponivel = quantidade;
            dadosAtualizar.ISBN = isnb;
            dadosAtualizar.Editora = editora;
            atualizar.Update(dadosAtualizar);

            AtualizaraBanco();
            LimparCampos();

            MessageBox.Show("Atualizado com sucesso", "Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
