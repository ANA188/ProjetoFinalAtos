namespace EmprestimoBiblioteca
{
    partial class CadDevolucaoT
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
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnConsultar2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 27);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 26;
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
            label1.TabIndex = 25;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(475, 86);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(113, 35);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(354, 86);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(132, 35);
            btnAdicionar.TabIndex = 23;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(589, 178);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 23);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(218, 178);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(365, 23);
            txtBuscar.TabIndex = 21;
            // 
            // btnConsultar2
            // 
            btnConsultar2.Location = new Point(241, 86);
            btnConsultar2.Name = "btnConsultar2";
            btnConsultar2.Size = new Size(117, 35);
            btnConsultar2.TabIndex = 20;
            btnConsultar2.Text = "Consultar";
            btnConsultar2.UseVisualStyleBackColor = true;
            btnConsultar2.Click += btnConsultar2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 207);
            dataGridView1.TabIndex = 19;
            // 
            // CadDevolucaoT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnConsultar2);
            Controls.Add(dataGridView1);
            Name = "CadDevolucaoT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadDevolucaoT";
            Load += CadDevolucaoT_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label label1;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnConsultar2;
        private DataGridView dataGridView1;
    }
}