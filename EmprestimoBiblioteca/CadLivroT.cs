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
    public partial class CadLivroT : Form
    {
        public CadLivroT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// Consulta informações do livro selecionado
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LivroId"].Value);

                using (var frm = new ConsultarLivro(id, Operacao.Consultar))
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)//Altera informações do livro selecionado
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LivroId"].Value);

                using (var frm = new ConsultarLivro(id, Operacao.Alterar))
                    frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione um livro na grade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {


            using (var frm = new ConsultarLivro(0, Operacao.Adicionar))
                frm.ShowDialog();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LivroId"].Value);

                using (var frm = new ConsultarLivro(id, Operacao.Excluir))
                    frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione um livro na grade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void CadLivroT_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
