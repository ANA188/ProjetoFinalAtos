using BibliotecaApi.Models;
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
    public partial class ConsultarEmprestimo : Form
    {
        private EmprestimoW _emprestimo = new EmprestimoW();
        private Operacao _operacao = new Operacao();
        private LivroW _livro = new LivroW();

        public ConsultarEmprestimo(int id, Operacao operacao)
        {
            InitializeComponent();
            _emprestimo.EmprestimoId = id;
            _operacao = operacao;

            BotaoSelecionado();
        }

        private async void BotaoSelecionado()
        {
            if (_operacao == Operacao.Consultar)
            {
                _emprestimo = await _emprestimo.ObterEmprestimoAsync(_emprestimo.EmprestimoId);
                if (_emprestimo != null)
                {

                    MostrarEmprestimo(_emprestimo);
                }

                btnExcluir.Visible = false;
                txtBuscar.Visible = false;
                btnBuscar.Visible = false;
                dataGridView1.Visible = false;
                btnSalvar.Visible = false;

                BloquearControles(true);
            }
            else if (_operacao == Operacao.Alterar)

            {

                _emprestimo = await _emprestimo.ObterEmprestimoAsync(_emprestimo.LivroId);

                if (_emprestimo != null)
                {
                    MostrarEmprestimo(_emprestimo);
                    btnSalvar.Visible = true;
                }


            }
            else if (_operacao == Operacao.Adicionar)
            {
                btnSalvar.Visible = true;
                btnExcluir.Visible = false;
                txtEmpId.Visible = false;
                txtDataEmp.Visible = false;
                txtDataDev.Visible = false;
                lblDataEmp.Visible = false;
                lblEmpId.Visible = false;
                label3.Visible = false;

            }
            else if (_operacao == Operacao.Excluir)
            {
                _emprestimo = await _emprestimo.ObterEmprestimoAsync(_emprestimo.EmprestimoId);
                if (_emprestimo != null)
                {

                    MostrarEmprestimo(_emprestimo);
                }
                BloquearControles(true);

                btnExcluir.Visible = true;
                btnSalvar.Visible = false;
                dataGridView1.Visible = false;
                txtBuscar.Visible = false;
                btnBuscar.Visible = false;



            }
        }

        private void MostrarEmprestimo(EmprestimoW emprestimo)
        {
            txtEmpId.Text = _emprestimo.EmprestimoId.ToString();
            txtRm.Text = _emprestimo.LeitorId.ToString();
            txtLivroId.Text = _emprestimo.LivroId.ToString();

            txtDataEmp.Text = _emprestimo.DataEmprestimo.ToString();
            txtDataDev.Text = _emprestimo.DataDevolucaoPrevista.ToString();


        }

        private void BloquearControles(bool travar)//Dasabilita o acesso ao textBox
        {
            txtEmpId.Enabled = !travar;
            txtRm.Enabled = !travar;
            txtLivroId.Enabled = !travar;
            txtDataEmp.Enabled = !travar;
            txtDataDev.Enabled = !travar;


        }

        private void CadEmprestimo_Load(object sender, EventArgs e)
        {

        }

        private void LivroIdLb_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private async void btnExcluir_ClickAsync(object sender, EventArgs e)
        {
            bool ok = await _emprestimo.DeletarEmprestimo(_emprestimo.EmprestimoId);
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

        private async void btnSalvar_ClickAsync(object sender, EventArgs e)
        {

             _emprestimo.LeitorId = Convert.ToInt32("0" + txtRm.Text);
            _emprestimo.LivroId = Convert.ToInt32("0" + txtLivroId.Text);
            

            if (_emprestimo.EmprestimoId == 0)
            {
                {
                    var emprestimo = await _emprestimo.AdicionarEmprestimo(_emprestimo);

                    if (emprestimo.EmprestimoId > 0)
                    {
                        MessageBox.Show("Salvo com sucesso! Id: " + emprestimo.EmprestimoId);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao salvar!");
                    }
                }
            }
        } 
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private async void btnBuscar_ClickAsync(object sender, EventArgs e)
        {
            label1.Text = "Buscando informações...";
            var livro = new LivroW();

            var listaLivro = new List<LivroW>();
            if (txtBuscar.Text == "")
            {
                listaLivro = await livro.BuscarTodosAsync();
            }
            else
            {
                listaLivro = await livro.BuscarPorTituloAsync(txtBuscar.Text);

            }
            dataGridView1.DataSource = listaLivro;

            GridConfig();

            label1.Text = "";

        }
        private void GridConfig()
        {
            dataGridView1.Columns["LivroId"].HeaderText = "LivroId";
            dataGridView1.Columns["LivroId"].Width = 100;
            dataGridView1.Columns["LivroId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LivroId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Titulo"].HeaderText = "Título";
            dataGridView1.Columns["Titulo"].Width = 200;
            dataGridView1.Columns["Titulo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Autor"].HeaderText = "Autor";
            dataGridView1.Columns["Autor"].Width = 150;
            dataGridView1.Columns["Autor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Autor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Categoria"].HeaderText = "Categoria";
            dataGridView1.Columns["Categoria"].Width = 170;
            dataGridView1.Columns["Categoria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Categoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["QuantidadeDisponivel"].HeaderText = "Quantidade Disponível";
            dataGridView1.Columns["QuantidadeDisponivel"].Width = 130;
            dataGridView1.Columns["QuantidadeDisponivel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["QuantidadeDisponivel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}

