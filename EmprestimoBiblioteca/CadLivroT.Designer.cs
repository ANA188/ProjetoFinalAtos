namespace EmprestimoBiblioteca
{
    partial class CadLivroT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnConsultar = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnAlterar = new Button();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 207);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(187, 71);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(117, 35);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(218, 163);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(365, 23);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(589, 163);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(301, 71);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(117, 35);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(415, 71);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(118, 35);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(529, 71);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 35);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 171);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            label1.Click += label1_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // CadLivroT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(btnAlterar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnConsultar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CadLivroT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadLivroT";
            Load += CadLivroT_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnConsultar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnAlterar;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Label label1;
        private Button btnVoltar;
    }
}