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
    public partial class ConsultarLeitor : Form
    {
        private LeitorW _leitor = new LeitorW();
        private Operacao _operacao = new Operacao();
        public ConsultarLeitor(int id, Operacao operacao)
        {
            InitializeComponent();
            _leitor.LeitorId = id;
            _operacao = operacao;

            BotaoSelecionado();
        }
        private async void BotaoSelecionado()
        {
            if (_operacao == Operacao.Consultar)
            {
                _leitor = await _leitor.ObterLeitorAsync(_leitor.LeitorId);
                if (_leitor != null)
                {

                    MostrarLeitor(_leitor);
                }
                btnSalvar.Visible=false;
                btnExcluir.Visible = false;
                BloquearControles(true);
            }
            else if (_operacao == Operacao.Alterar)

            {

                _leitor = await _leitor.ObterLeitorAsync(_leitor.LeitorId);

                if (_leitor != null)
                {
                    MostrarLeitor(_leitor);

                }

                btnExcluir.Visible=false;
                txtRm.Enabled = false;


            }
            else if (_operacao == Operacao.Adicionar)
            {
                btnExcluir.Visible = false;
                txtRm.Enabled = false;

            }
            else if (_operacao == Operacao.Excluir)
            {
                _leitor = await _leitor.ObterLeitorAsync(_leitor.LeitorId);
                if (_leitor != null)
                {

                    MostrarLeitor(_leitor);
                }
                BloquearControles(true);

                btnExcluir.Visible = true;
                btnSalvar.Visible = false;
            }
        }

        private void MostrarLeitor(LeitorW leitor)
        {
            txtRm.Text = _leitor.LeitorId.ToString();
            txtNome.Text = _leitor.Nome;
            txtCPF.Text = _leitor.CPF;
            txtEnd.Text = _leitor.Endereco;
            txtCont.Text = _leitor.Contato;
            txtData.Text = _leitor.DataNascimento;
           


        }

        private void BloquearControles(bool travar)//Dasabilita o acesso ao textBox
        {
            txtRm.Enabled = !travar;
            txtNome.Enabled = !travar;
            txtCPF.Enabled = !travar;
            txtEnd.Enabled = !travar;
            txtData.Enabled = !travar;
            txtCont.Enabled = !travar;

        }

        private void ConsultarLeitor_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            _leitor.LeitorId = Convert.ToInt32("0" + txtRm.Text);
            _leitor.Nome = txtNome.Text;
            _leitor.CPF = txtCPF.Text;
            _leitor.Endereco = txtEnd.Text;
            _leitor.Contato = txtCont.Text;
            _leitor.DataNascimento = txtData.Text;
           // _leitor = new LeitorW();  
            if (_leitor.LeitorId == 0)
            {
                var leitor = await _leitor.AdicionarLeitor(_leitor);

                if (leitor.LeitorId > 0)
                {
                    MessageBox.Show("Salvo com sucesso! Id: " + leitor.LeitorId);
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha ao salvar!awawawawaw");
                }
            }
            else
            {
                bool ok = await _leitor.AtualizarLeitor(_leitor.LeitorId, _leitor);
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

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            bool ok = await _leitor.DeletarLeitor(_leitor.LeitorId);
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

