namespace EmprestimoBiblioteca
{
    partial class ConsultarDevolucao
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
            txtEmpId = new TextBox();
            txtLeitorId = new TextBox();
            txtLivroId = new TextBox();
            EmprestimoIdLb = new Label();
            LeitorIdLb = new Label();
            LivroIdLb = new Label();
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            btnSalvar = new Button();
            txtBuscar = new TextBox();
            btnExcluir = new Button();
            txtDataDev = new TextBox();
            txtDataPrev = new TextBox();
            txtDevId = new TextBox();
            lblDataPrev = new Label();
            lblDataDevolucao = new Label();
            lblDevlucaoId = new Label();
            label1 = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(362, 37);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(100, 23);
            txtEmpId.TabIndex = 0;
            // 
            // txtLeitorId
            // 
            txtLeitorId.Location = new Point(362, 75);
            txtLeitorId.Name = "txtLeitorId";
            txtLeitorId.Size = new Size(100, 23);
            txtLeitorId.TabIndex = 1;
            // 
            // txtLivroId
            // 
            txtLivroId.Location = new Point(362, 116);
            txtLivroId.Name = "txtLivroId";
            txtLivroId.Size = new Size(100, 23);
            txtLivroId.TabIndex = 2;
            // 
            // EmprestimoIdLb
            // 
            EmprestimoIdLb.AutoSize = true;
            EmprestimoIdLb.Location = new Point(226, 37);
            EmprestimoIdLb.Name = "EmprestimoIdLb";
            EmprestimoIdLb.Size = new Size(104, 15);
            EmprestimoIdLb.TabIndex = 3;
            EmprestimoIdLb.Text = "Id do Emprestimo:";
            // 
            // LeitorIdLb
            // 
            LeitorIdLb.AutoSize = true;
            LeitorIdLb.Location = new Point(249, 78);
            LeitorIdLb.Name = "LeitorIdLb";
            LeitorIdLb.Size = new Size(78, 15);
            LeitorIdLb.TabIndex = 4;
            LeitorIdLb.Text = "RM do Leitor:";
            // 
            // LivroIdLb
            // 
            LivroIdLb.AutoSize = true;
            LivroIdLb.Location = new Point(261, 119);
            LivroIdLb.Name = "LivroIdLb";
            LivroIdLb.Size = new Size(66, 15);
            LivroIdLb.TabIndex = 5;
            LivroIdLb.Text = "Id do Livro:";
            LivroIdLb.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 145);
            dataGridView1.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(525, 277);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_ClickAsync;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(359, 242);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 31);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(270, 278);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(249, 23);
            txtBuscar.TabIndex = 9;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(359, 254);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(103, 30);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtDataDev
            // 
            txtDataDev.Location = new Point(362, 158);
            txtDataDev.Name = "txtDataDev";
            txtDataDev.Size = new Size(134, 23);
            txtDataDev.TabIndex = 11;
            // 
            // txtDataPrev
            // 
            txtDataPrev.Location = new Point(362, 199);
            txtDataPrev.Name = "txtDataPrev";
            txtDataPrev.Size = new Size(134, 23);
            txtDataPrev.TabIndex = 12;
            // 
            // txtDevId
            // 
            txtDevId.Location = new Point(362, 0);
            txtDevId.Name = "txtDevId";
            txtDevId.Size = new Size(100, 23);
            txtDevId.TabIndex = 13;
            // 
            // lblDataPrev
            // 
            lblDataPrev.AutoSize = true;
            lblDataPrev.Location = new Point(179, 202);
            lblDataPrev.Name = "lblDataPrev";
            lblDataPrev.Size = new Size(154, 15);
            lblDataPrev.TabIndex = 14;
            lblDataPrev.Text = "Data De Devolução Prevista:";
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Location = new Point(226, 161);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new Size(109, 15);
            lblDataDevolucao.TabIndex = 15;
            lblDataDevolucao.Text = "Data de Devolução:";
            // 
            // lblDevlucaoId
            // 
            lblDevlucaoId.AutoSize = true;
            lblDevlucaoId.Location = new Point(235, 3);
            lblDevlucaoId.Name = "lblDevlucaoId";
            lblDevlucaoId.Size = new Size(95, 15);
            lblDevlucaoId.TabIndex = 16;
            lblDevlucaoId.Text = "Id da Devolução:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 281);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // ConsultarDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(lblDevlucaoId);
            Controls.Add(lblDataDevolucao);
            Controls.Add(lblDataPrev);
            Controls.Add(txtDevId);
            Controls.Add(txtDataPrev);
            Controls.Add(txtDataDev);
            Controls.Add(btnExcluir);
            Controls.Add(txtBuscar);
            Controls.Add(btnSalvar);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(LivroIdLb);
            Controls.Add(LeitorIdLb);
            Controls.Add(EmprestimoIdLb);
            Controls.Add(txtLivroId);
            Controls.Add(txtLeitorId);
            Controls.Add(txtEmpId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConsultarDevolucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadDevolucao";
            Load += ConsultarDevolucao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmpId;
        private TextBox txtLeitorId;
        private TextBox txtLivroId;
        private Label EmprestimoIdLb;
        private Label LeitorIdLb;
        private Label LivroIdLb;
        private DataGridView dataGridView1;
        private Button btnBuscar;
        private Button btnSalvar;
        private TextBox txtBuscar;
        private Button btnExcluir;
        private TextBox txtDataDev;
        private TextBox txtDataPrev;
        private TextBox txtDevId;
        private Label lblDataPrev;
        private Label lblDataDevolucao;
        private Label lblDevlucaoId;
        private Label label1;
        private Button btnVoltar;
    }
}