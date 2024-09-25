namespace EmprestimoBiblioteca
{
    partial class ConsultarEmprestimo
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
            txtRm = new TextBox();
            txtLivroId = new TextBox();
            lblLeitorId = new Label();
            LivroIdLb = new Label();
            dataGridView1 = new DataGridView();
            btnSalvar = new Button();
            txtBuscar = new MaskedTextBox();
            btnBuscar = new Button();
            btnVoltar = new Button();
            txtEmpId = new TextBox();
            lblEmpId = new Label();
            lblDataEmp = new Label();
            label3 = new Label();
            label4 = new Label();
            btnExcluir = new Button();
            txtDataEmp = new TextBox();
            txtDataDev = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtRm
            // 
            txtRm.Location = new Point(365, 46);
            txtRm.Name = "txtRm";
            txtRm.Size = new Size(100, 23);
            txtRm.TabIndex = 0;
            // 
            // txtLivroId
            // 
            txtLivroId.Location = new Point(365, 85);
            txtLivroId.Name = "txtLivroId";
            txtLivroId.Size = new Size(100, 23);
            txtLivroId.TabIndex = 1;
            // 
            // lblLeitorId
            // 
            lblLeitorId.AutoSize = true;
            lblLeitorId.Location = new Point(252, 54);
            lblLeitorId.Name = "lblLeitorId";
            lblLeitorId.Size = new Size(78, 15);
            lblLeitorId.TabIndex = 2;
            lblLeitorId.Text = "RM do Leitor:";
            // 
            // LivroIdLb
            // 
            LivroIdLb.AutoSize = true;
            LivroIdLb.Location = new Point(264, 93);
            LivroIdLb.Name = "LivroIdLb";
            LivroIdLb.Size = new Size(66, 15);
            LivroIdLb.TabIndex = 3;
            LivroIdLb.Text = "Id do Livro:";
            LivroIdLb.Click += LivroIdLb_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 302);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 136);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(365, 210);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 30);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_ClickAsync;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(239, 273);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(297, 23);
            txtBuscar.TabIndex = 6;
            txtBuscar.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(542, 277);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_ClickAsync;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(365, 12);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(100, 23);
            txtEmpId.TabIndex = 9;
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(226, 20);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(104, 15);
            lblEmpId.TabIndex = 12;
            lblEmpId.Text = "Id do Emprestimo:";
            lblEmpId.Click += label1_Click;
            // 
            // lblDataEmp
            // 
            lblDataEmp.AutoSize = true;
            lblDataEmp.Location = new Point(225, 137);
            lblDataEmp.Name = "lblDataEmp";
            lblDataEmp.Size = new Size(118, 15);
            lblDataEmp.TabIndex = 13;
            lblDataEmp.Text = "Data do Emprestimo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 177);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 14;
            label3.Text = "Data de devolução Prevista:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 281);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 15;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(365, 219);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(98, 30);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_ClickAsync;
            // 
            // txtDataEmp
            // 
            txtDataEmp.Location = new Point(363, 134);
            txtDataEmp.Name = "txtDataEmp";
            txtDataEmp.Size = new Size(156, 23);
            txtDataEmp.TabIndex = 17;
            // 
            // txtDataDev
            // 
            txtDataDev.Location = new Point(363, 174);
            txtDataDev.Name = "txtDataDev";
            txtDataDev.Size = new Size(156, 23);
            txtDataDev.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 277);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 19;
            // 
            // ConsultarEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(txtDataDev);
            Controls.Add(txtDataEmp);
            Controls.Add(btnExcluir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblDataEmp);
            Controls.Add(lblEmpId);
            Controls.Add(txtEmpId);
            Controls.Add(btnVoltar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnSalvar);
            Controls.Add(dataGridView1);
            Controls.Add(LivroIdLb);
            Controls.Add(lblLeitorId);
            Controls.Add(txtLivroId);
            Controls.Add(txtRm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConsultarEmprestimo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadEmprestimo";
            Load += CadEmprestimo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRm;
        private TextBox txtLivroId;
        private Label lblLeitorId;
        private Label LivroIdLb;
        private DataGridView dataGridView1;
        private Button btnSalvar;
        private MaskedTextBox txtBuscar;
        private Button btnBuscar;
        private Button btnVoltar;
        private TextBox txtEmpId;
        private Label lblEmpId;
        private Label lblDataEmp;
        private Label label3;
        private Label label4;
        private Button btnExcluir;
        private TextBox txtDataEmp;
        private TextBox txtDataDev;
        private Label label1;
    }
}