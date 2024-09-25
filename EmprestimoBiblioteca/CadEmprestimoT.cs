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
    public partial class CadEmprestimoT : Form
    {
        public CadEmprestimoT()
        {
            InitializeComponent();
        }

        private void CadEmprestimoT_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EmprestimoId"].Value);

                using (var frmCe = new ConsultarEmprestimo(id, Operacao.Consultar))
                    frmCe.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione um emprestimo na grade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new ConsultarEmprestimo(0, Operacao.Adicionar))
                frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EmprestimoId"].Value);

                using (var frm = new ConsultarEmprestimo(id, Operacao.Excluir))
                    frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione um emprestimo teste na grade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnBuscar_ClickAsync(object sender, EventArgs e)
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
            dataGridView1.Columns["EmprestimoId"].Width = 130;
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

            dataGridView1.Columns["DataDevolucaoPrevista"].HeaderText = "Data de Devolução Prevista";
            dataGridView1.Columns["DataDevolucaoPrevista"].Width = 150;
            dataGridView1.Columns["DataDevolucaoPrevista"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DataDevolucaoPrevista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
