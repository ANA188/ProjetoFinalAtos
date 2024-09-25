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
    public partial class ConsultarDevolucao : Form
    {
        private DevolucaoW _devolucao = new DevolucaoW();
        private Operacao _operacao = new Operacao();
        public ConsultarDevolucao(int id, Operacao operacao)
        {
            InitializeComponent();
            _devolucao.DevolucaoId = id;
            _operacao = operacao;

            BotaoSelecionado();
        }
        private async void BotaoSelecionado()
        {
            if (_operacao == Operacao.Consultar)
            {
                _devolucao = await _devolucao.ObterDevolucaoAsync(_devolucao.DevolucaoId);
                if (_devolucao != null)
                {
                    MostrarDevolucao(_devolucao);
                }

                dataGridView1.Visible = false;
                txtBuscar.Visible = false;
                btnExcluir.Visible = false;
                btnSalvar.Visible = false;
                btnBuscar.Visible = false;

                BloquearControles(true);
            }
            else if (_operacao == Operacao.Adicionar)
            {
                btnSalvar.Visible = true;
                btnExcluir.Visible = false;
                txtDevId.Visible = false;
                txtDataDev.Visible = false;
                txtDataPrev.Visible = false;
                lblDevlucaoId.Visible = false;
                lblDataPrev.Visible = false;
                lblDataDevolucao.Visible = false;



            }
            else if (_operacao == Operacao.Excluir)
            {
                _devolucao = await _devolucao.ObterDevolucaoAsync(_devolucao.DevolucaoId);
                if (_devolucao != null)
                {

                    MostrarDevolucao(_devolucao);
                }
                BloquearControles(true);

                btnExcluir.Visible = true;
                btnSalvar.Visible = false;
                dataGridView1.Visible = false;
                txtBuscar.Visible = false;
                btnBuscar.Visible = false;



            }
        }
        private void MostrarDevolucao(DevolucaoW devolucao)
        {
            txtDevId.Text = _devolucao.DevolucaoId.ToString();
            txtEmpId.Text = _devolucao.EmprestimoId.ToString();
            txtLeitorId.Text = _devolucao.LeitorId.ToString();
            txtLivroId.Text = _devolucao.LivroId.ToString();
            txtDataDev.Text = _devolucao.DataDevolucao.ToString();
            txtDataPrev.Text = _devolucao.DataDevolucaoPrevista.ToString();


        }
        private void BloquearControles(bool travar)//Dasabilita o acesso ao textBox
        {
            txtDevId.Enabled = !travar;
            txtEmpId.Enabled = !travar;
            txtLeitorId.Enabled = !travar;
            txtLivroId.Enabled = !travar;
            txtDataDev.Enabled = !travar;
            txtDataPrev.Enabled = !travar;


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button1_ClickAsync(object sender, EventArgs e)//Buscar
        {

            label1.Text = "Buscando informações...";
            var emprestimo = new EmprestimoW();

            var listaEmprestimo = new List<EmprestimoW>();
            if (txtBuscar.Text == "")
            {
                listaEmprestimo = await emprestimo.BuscarTodosAsync();
            }
            else
            {
                listaEmprestimo = await emprestimo.BuscarPorLeitorIdAsync(int.Parse(txtBuscar.Text));

            }
            dataGridView1.DataSource = listaEmprestimo;

            GridConfig();

            label1.Text = "";
        }
        private void GridConfig()
        {
            dataGridView1.Columns["EmprestimoId"].HeaderText = "Emprestimo Id";
            dataGridView1.Columns["EmprestimoId"].Width = 100;
            dataGridView1.Columns["EmprestimoId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["EmprestimoId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["LeitorId"].HeaderText = "RM do Leitor";
            dataGridView1.Columns["LeitorId"].Width = 150;
            dataGridView1.Columns["LeitorId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LeitorId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["LivroId"].HeaderText = "Livro Id";
            dataGridView1.Columns["LivroId"].Width = 150;
            dataGridView1.Columns["LivroId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LivroId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["DataEmprestimo"].HeaderText = "Data De Emprestimo";
            dataGridView1.Columns["DataEmprestimo"].Width = 150;
            dataGridView1.Columns["DataEmprestimo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DataEmprestimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["DataDevolucaoPrevista"].HeaderText = "Data de Devolução";
            dataGridView1.Columns["DataDevolucaoPrevista"].Width = 150;
            dataGridView1.Columns["DataDevolucaoPrevista"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DataDevolucaoPrevista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void ConsultarDevolucao_Load(object sender, EventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {

            _devolucao.EmprestimoId = Convert.ToInt32("0" + txtEmpId.Text);
            _devolucao.LivroId = Convert.ToInt32("0" + txtLivroId.Text);
            _devolucao.LeitorId = Convert.ToInt32("0" + txtLeitorId.Text);



            if (_devolucao.DevolucaoId == 0)
            {
                {
                    var devolucao = await _devolucao.AdicionarDevolucao(_devolucao);

                    if (devolucao.EmprestimoId > 0)
                    {
                        MessageBox.Show("Salvo com sucesso! Id: " + devolucao.DevolucaoId);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao salvar!");
                    }
                }
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            bool ok = await _devolucao.DeletarDevolucao(_devolucao.DevolucaoId);
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
