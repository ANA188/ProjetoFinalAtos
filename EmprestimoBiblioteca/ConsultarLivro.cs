using BibliotecaApi.Models;
using BibliotecaApi.Repositories;
using EmprestimoBiblioteca.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmprestimoBiblioteca
{
    public partial class ConsultarLivro : Form
    {
        private LivroW _livro = new LivroW();
        private Operacao _operacao = new Operacao();

        public ConsultarLivro(int id, Operacao operacao)
        {

            InitializeComponent();
            _livro.LivroId = id;
            _operacao = operacao;

            BotaoSelecionado();
        }

        private async void BotaoSelecionado()
        {
            if (_operacao == Operacao.Consultar)
            {
                _livro = await _livro.ObterLivroAsync(_livro.LivroId);
                if (_livro != null)
                {

                    MostrarLivro(_livro);
                }
                BloquearControles(true);
            }
            else if (_operacao == Operacao.Alterar)

            {

                _livro = await _livro.ObterLivroAsync(_livro.LivroId);

                if (_livro != null)
                {
                    MostrarLivro(_livro);
                    button1.Visible = true;
                }
                txtLivroId.Enabled = false;

            }
            else if (_operacao == Operacao.Adicionar)
            {
                button1.Visible = true;
                txtLivroId.Enabled = false;

            }
            else if (_operacao == Operacao.Excluir)
            {
                _livro = await _livro.ObterLivroAsync(_livro.LivroId);
                if (_livro != null)
                {

                    MostrarLivro(_livro);
                }
                BloquearControles(true);

                btnExcluir.Visible = true;

            }
        }

        private void MostrarLivro(LivroW livro)
        {
            txtLivroId.Text = _livro.LivroId.ToString();
            TxtTitulo.Text = _livro.Titulo;
            txtAutor.Text = _livro.Autor;
            TxtCat.Text = _livro.Categoria;
            TxtQuant.Text = _livro.QuantidadeDisponivel.ToString();
            

        }

        private void BloquearControles(bool travar)//Dasabilita o acesso ao textBox
        {
            txtLivroId.Enabled = !travar;
            txtAutor.Enabled = !travar;
            TxtTitulo.Enabled = !travar;
            TxtCat.Enabled = !travar;
            TxtQuant.Enabled = !travar;


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void QuantidadeLb_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadLivro_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)//Responsável por salvar/adicionar novos itens
        {
            if (_livro == null)
            {
                _livro = new LivroW(); // Instancia a classe Livro
            }
            _livro.LivroId = Convert.ToInt32("0" + txtLivroId.Text);
            _livro.Titulo = TxtTitulo.Text;
            _livro.Autor = txtAutor.Text;
            _livro.Categoria = TxtCat.Text;
            _livro.QuantidadeDisponivel = Convert.ToInt32("0" + TxtQuant.Text);


            if (_livro.LivroId == 0)
            {
                var livro = await _livro.AdicionarLivro(_livro);

                if (livro.LivroId > 0)
                {
                    MessageBox.Show("Salvo com sucesso! Id: " + livro.LivroId);
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha ao salvar!");
                }
            }
            else
            {
                bool ok = await _livro.AtualizarLivro(_livro.LivroId, _livro);
                if (ok)
                {
                    MessageBox.Show("Salvo com sucesso!");
                    Close();

                }
                else
                {
                    MessageBox.Show("Falha ao salvar!");
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLivroId_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            bool ok = await _livro.DeletarLivro(_livro.LivroId);
            if (ok)
            {
                MessageBox.Show("Excluído com sucesso!");
                Close();

            }
            else
            {
                MessageBox.Show("não foi possível excluir o iten! falha!");
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
