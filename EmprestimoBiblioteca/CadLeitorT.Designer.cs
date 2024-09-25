namespace EmprestimoBiblioteca
{
    partial class CadLeitorT
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
            btnVoltar = new Button();
            label1 = new Label();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnAlterar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnConsultar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 27);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 18;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 186);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(529, 86);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 35);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(415, 86);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(118, 35);
            btnAdicionar.TabIndex = 15;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(301, 86);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(117, 35);
            btnAlterar.TabIndex = 14;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(589, 178);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(218, 178);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(365, 23);
            txtBuscar.TabIndex = 12;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(187, 86);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(117, 35);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 207);
            dataGridView1.TabIndex = 10;
            // 
            // CadLeitorT
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
            Name = "CadLeitorT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadLeitorT";
            Load += CadLeitorT_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label label1;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnConsultar;
        private DataGridView dataGridView1;
    }
}