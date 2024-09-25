namespace EmprestimoBiblioteca
{
    partial class ConsultarLeitor
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
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtEnd = new TextBox();
            txtCont = new TextBox();
            txtData = new TextBox();
            label1 = new Label();
            CPFLb = new Label();
            EnderecoLb = new Label();
            ContatoLb = new Label();
            DataNascLb = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            btnExcluir = new Button();
            txtRm = new TextBox();
            lblRm = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(309, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(241, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(309, 99);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(241, 23);
            txtCPF.TabIndex = 1;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(309, 152);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(241, 23);
            txtEnd.TabIndex = 2;
            // 
            // txtCont
            // 
            txtCont.Location = new Point(309, 217);
            txtCont.Name = "txtCont";
            txtCont.Size = new Size(241, 23);
            txtCont.TabIndex = 3;
            txtCont.TextChanged += textBox4_TextChanged;
            // 
            // txtData
            // 
            txtData.Location = new Point(336, 272);
            txtData.Name = "txtData";
            txtData.Size = new Size(178, 23);
            txtData.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 54);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // CPFLb
            // 
            CPFLb.AutoSize = true;
            CPFLb.Location = new Point(229, 107);
            CPFLb.Name = "CPFLb";
            CPFLb.Size = new Size(31, 15);
            CPFLb.TabIndex = 6;
            CPFLb.Text = "CPF:";
            // 
            // EnderecoLb
            // 
            EnderecoLb.AutoSize = true;
            EnderecoLb.Location = new Point(201, 160);
            EnderecoLb.Name = "EnderecoLb";
            EnderecoLb.Size = new Size(59, 15);
            EnderecoLb.TabIndex = 7;
            EnderecoLb.Text = "Endereço:";
            // 
            // ContatoLb
            // 
            ContatoLb.AutoSize = true;
            ContatoLb.Location = new Point(207, 217);
            ContatoLb.Name = "ContatoLb";
            ContatoLb.Size = new Size(53, 15);
            ContatoLb.TabIndex = 8;
            ContatoLb.Text = "Contato:";
            // 
            // DataNascLb
            // 
            DataNascLb.AutoSize = true;
            DataNascLb.Location = new Point(143, 280);
            DataNascLb.Name = "DataNascLb";
            DataNascLb.Size = new Size(117, 15);
            DataNascLb.TabIndex = 9;
            DataNascLb.Text = "Data de Nascimento:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(361, 348);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(128, 32);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(24, 25);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 25);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(361, 364);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(128, 31);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtRm
            // 
            txtRm.Location = new Point(309, 12);
            txtRm.Name = "txtRm";
            txtRm.Size = new Size(241, 23);
            txtRm.TabIndex = 13;
            // 
            // lblRm
            // 
            lblRm.AutoSize = true;
            lblRm.Location = new Point(194, 20);
            lblRm.Name = "lblRm";
            lblRm.Size = new Size(78, 15);
            lblRm.TabIndex = 14;
            lblRm.Text = "Rm do Leitor:";
            // 
            // ConsultarLeitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblRm);
            Controls.Add(txtRm);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(DataNascLb);
            Controls.Add(ContatoLb);
            Controls.Add(EnderecoLb);
            Controls.Add(CPFLb);
            Controls.Add(label1);
            Controls.Add(txtData);
            Controls.Add(txtCont);
            Controls.Add(txtEnd);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConsultarLeitor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadLeitor";
            Load += ConsultarLeitor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtEnd;
        private TextBox txtCont;
        private TextBox txtData;
        private Label label1;
        private Label CPFLb;
        private Label EnderecoLb;
        private Label ContatoLb;
        private Label DataNascLb;
        private Button btnSalvar;
        private Button btnVoltar;
        private Button btnExcluir;
        private TextBox txtRm;
        private Label lblRm;
    }
}