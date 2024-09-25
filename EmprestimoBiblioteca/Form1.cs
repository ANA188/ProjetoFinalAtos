namespace EmprestimoBiblioteca
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void cadadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadLivroT cadLivroT = new CadLivroT();
            cadLivroT.Show();



        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadEmprestimoT cadEmprestimoT = new CadEmprestimoT();
            cadEmprestimoT.Show();
        }

        private void devoluçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadDevolucaoT devolucao = new CadDevolucaoT();
            devolucao.Show();
        }

        private void leitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLeitorT leitor = new CadLeitorT();
            leitor.Show();
        }
    }
}