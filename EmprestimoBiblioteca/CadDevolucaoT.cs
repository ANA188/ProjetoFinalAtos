using EmprestimoBiblioteca.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmprestimoBiblioteca
{
    public partial class CadDevolucaoT : Form
    {

        public CadDevolucaoT()
        {
            InitializeComponent();

        }

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["DevolucaoId"].Value);

                using (var frmCe = new ConsultarDevolucao(id, Operacao.Consultar))
                    frmCe.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione uma devolução na grade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new ConsultarDevolucao(0, Operacao.Adicionar))
                frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["DevolucaoId"].Value);

                using (var frm = new ConsultarDevolucao(id, Operacao.Excluir))
                    frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione uma devolução teste na grade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            label1.Text = "Buscando informações...";
            var devolucao = new DevolucaoW();

            var listaDevolucao = new List<DevolucaoW>();
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                listaDevolucao = await devolucao.BuscarTodosAsync();
            }
            else
            {  if (int.TryParse(txtBuscar.Text, out int leitorId))
                {
                    listaDevolucao = await devolucao.BuscarPorLeitorIdAsync(int.Parse(txtBuscar.Text));
                }
                else
                {
                    MessageBox.Show("Digite somente números inteiros");
                }
            }
            dataGridView1.DataSource = listaDevolucao;

            GridConfig();

            label1.Text = "";
        }
        private void GridConfig()
        {
            dataGridView1.Columns["DevolucaoId"].HeaderText = "Devolução Id";
            dataGridView1.Columns["DevolucaoId"].Width = 130;
            dataGridView1.Columns["DevolucaoId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DevolucaoId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["EmprestimoId"].HeaderText = "Emprestimo Id";
            dataGridView1.Columns["EmprestimoId"].Width = 150;
            dataGridView1.Columns["EmprestimoId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["EmprestimoId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["LeitorId"].HeaderText = "Rm do Leitor";
            dataGridView1.Columns["LeitorId"].Width = 150;
            dataGridView1.Columns["LeitorId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LeitorId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["LivroId"].HeaderText = "Livro Id";
            dataGridView1.Columns["LivroId"].Width = 150;
            dataGridView1.Columns["LivroId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LivroId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["DataDevolucao"].HeaderText = "Data de Devolução";
            dataGridView1.Columns["DataDevolucao"].Width = 150;
            dataGridView1.Columns["DataDevolucao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DataDevolucao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["DataDevolucaoPrevista"].HeaderText = "Data de Devolução Prevista";
            dataGridView1.Columns["DataDevolucaoPrevista"].Width = 150;
            dataGridView1.Columns["DataDevolucaoPrevista"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DataDevolucaoPrevista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CadDevolucaoT_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
