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
    public partial class CadLeitorT : Form
    {
        public CadLeitorT()
        {
            InitializeComponent();
        }

        private void CadLeitorT_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LeitorId"].Value);

                using (var frm = new ConsultarLeitor(id, Operacao.Consultar))
                    frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione um livro na grade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            label1.Text = "Buscando informações...";
            var leitor = new LeitorW();

            var listaLeitor = new List<LeitorW>();
            if (txtBuscar.Text == "")
            {
                listaLeitor = await leitor.BuscarTodosAsync();
                dataGridView1.DataSource = listaLeitor;

            }
            else
            {
                var leitorEspecifico = await leitor.ObterLeitorAsync(int.Parse(txtBuscar.Text));
                dataGridView1.DataSource = leitorEspecifico;
            }



            GridConfig();

            label1.Text = "";
        }
        private void GridConfig()
        {
            dataGridView1.Columns["LeitorId"].HeaderText = "RM Leitor";
            dataGridView1.Columns["LeitorId"].Width = 80;
            dataGridView1.Columns["LeitorId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LeitorId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Nome"].HeaderText = "Nome";
            dataGridView1.Columns["Nome"].Width = 200;
            dataGridView1.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["CPF"].HeaderText = "CPF";
            dataGridView1.Columns["CPF"].Width = 130;
            dataGridView1.Columns["CPF"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CPF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Endereco"].HeaderText = "Endereço";
            dataGridView1.Columns["Endereco"].Width = 170;
            dataGridView1.Columns["Endereco"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Endereco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Contato"].HeaderText = "Contato";
            dataGridView1.Columns["Contato"].Width = 130;
            dataGridView1.Columns["Contato"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Contato"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["DataNascimento"].HeaderText = "Data de nascimento";
            dataGridView1.Columns["DataNascimento"].Width = 130;
            dataGridView1.Columns["DataNascimento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DataNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LeitorId"].Value);

                using (var frm = new ConsultarLeitor(id, Operacao.Alterar))
                    frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione um item na grade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new ConsultarLeitor(0, Operacao.Adicionar))
                frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LeitorId"].Value);

                using (var frm = new ConsultarLeitor(id, Operacao.Excluir))
                    frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione um item na grade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

