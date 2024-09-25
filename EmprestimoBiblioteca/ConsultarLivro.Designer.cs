namespace EmprestimoBiblioteca
{
    partial class ConsultarLivro
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
            TxtTitulo = new TextBox();
            txtAutor = new TextBox();
            TxtCat = new TextBox();
            TxtQuant = new TextBox();
            TituloLb = new Label();
            AutorLb = new Label();
            CategoriaLb = new Label();
            QuantidadeLb = new Label();
            button1 = new Button();
            label1 = new Label();
            txtLivroId = new TextBox();
            btnExcluir = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(305, 93);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(212, 23);
            TxtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(305, 152);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(212, 23);
            txtAutor.TabIndex = 1;
            // 
            // TxtCat
            // 
            TxtCat.Location = new Point(305, 207);
            TxtCat.Name = "TxtCat";
            TxtCat.Size = new Size(212, 23);
            TxtCat.TabIndex = 2;
            // 
            // TxtQuant
            // 
            TxtQuant.Location = new Point(305, 267);
            TxtQuant.Name = "TxtQuant";
            TxtQuant.Size = new Size(212, 23);
            TxtQuant.TabIndex = 3;
            TxtQuant.TextChanged += textBox4_TextChanged;
            // 
            // TituloLb
            // 
            TituloLb.AutoSize = true;
            TituloLb.Location = new Point(221, 93);
            TituloLb.Name = "TituloLb";
            TituloLb.Size = new Size(37, 15);
            TituloLb.TabIndex = 4;
            TituloLb.Text = "Título";
            // 
            // AutorLb
            // 
            AutorLb.AutoSize = true;
            AutorLb.Location = new Point(221, 160);
            AutorLb.Name = "AutorLb";
            AutorLb.Size = new Size(40, 15);
            AutorLb.TabIndex = 5;
            AutorLb.Text = "Autor:";
            // 
            // CategoriaLb
            // 
            CategoriaLb.AutoSize = true;
            CategoriaLb.Location = new Point(204, 215);
            CategoriaLb.Name = "CategoriaLb";
            CategoriaLb.Size = new Size(61, 15);
            CategoriaLb.TabIndex = 6;
            CategoriaLb.Text = "Categoria:";
            CategoriaLb.Click += label3_Click;
            // 
            // QuantidadeLb
            // 
            QuantidadeLb.AutoSize = true;
            QuantidadeLb.Location = new Point(140, 275);
            QuantidadeLb.Name = "QuantidadeLb";
            QuantidadeLb.Size = new Size(130, 15);
            QuantidadeLb.TabIndex = 7;
            QuantidadeLb.Text = "Quantidade Disponível:";
            QuantidadeLb.Click += QuantidadeLb_Click;
            // 
            // button1
            // 
            button1.Location = new Point(352, 361);
            button1.Name = "button1";
            button1.Size = new Size(107, 30);
            button1.TabIndex = 8;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 9;
            label1.Text = "Id do Livro:";
            // 
            // txtLivroId
            // 
            txtLivroId.Location = new Point(305, 38);
            txtLivroId.Name = "txtLivroId";
            txtLivroId.Size = new Size(212, 23);
            txtLivroId.TabIndex = 10;
            txtLivroId.TextChanged += txtLivroId_TextChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(352, 371);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(107, 30);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Visible = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // ConsultarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnVoltar);
            Controls.Add(btnExcluir);
            Controls.Add(txtLivroId);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(QuantidadeLb);
            Controls.Add(CategoriaLb);
            Controls.Add(AutorLb);
            Controls.Add(TituloLb);
            Controls.Add(TxtQuant);
            Controls.Add(TxtCat);
            Controls.Add(txtAutor);
            Controls.Add(TxtTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConsultarLivro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadLivro";
            Load += CadLivro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtTitulo;
        private TextBox txtAutor;
        private TextBox TxtCat;
        private TextBox TxtQuant;
        private Label TituloLb;
        private Label AutorLb;
        private Label CategoriaLb;
        private Label QuantidadeLb;
        private Button button1;
        private Label label1;
        private TextBox txtLivroId;
        private Button btnExcluir;
        private Button btnVoltar;
    }
}