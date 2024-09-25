namespace EmprestimoBiblioteca
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadadastroToolStripMenuItem = new ToolStripMenuItem();
            empréstimosToolStripMenuItem = new ToolStripMenuItem();
            devoluçõesToolStripMenuItem = new ToolStripMenuItem();
            leitorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadadastroToolStripMenuItem, empréstimosToolStripMenuItem, devoluçõesToolStripMenuItem, leitorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadadastroToolStripMenuItem
            // 
            cadadastroToolStripMenuItem.Name = "cadadastroToolStripMenuItem";
            cadadastroToolStripMenuItem.Size = new Size(50, 20);
            cadadastroToolStripMenuItem.Text = "Livros";
            cadadastroToolStripMenuItem.Click += cadadastroToolStripMenuItem_Click;
            // 
            // empréstimosToolStripMenuItem
            // 
            empréstimosToolStripMenuItem.Name = "empréstimosToolStripMenuItem";
            empréstimosToolStripMenuItem.Size = new Size(88, 20);
            empréstimosToolStripMenuItem.Text = "Empréstimos";
            empréstimosToolStripMenuItem.Click += empréstimosToolStripMenuItem_Click;
            // 
            // devoluçõesToolStripMenuItem
            // 
            devoluçõesToolStripMenuItem.Name = "devoluçõesToolStripMenuItem";
            devoluçõesToolStripMenuItem.Size = new Size(80, 20);
            devoluçõesToolStripMenuItem.Text = "Devoluções";
            devoluçõesToolStripMenuItem.Click += devoluçõesToolStripMenuItem_Click;
            // 
            // leitorToolStripMenuItem
            // 
            leitorToolStripMenuItem.Name = "leitorToolStripMenuItem";
            leitorToolStripMenuItem.Size = new Size(60, 20);
            leitorToolStripMenuItem.Text = "Leitores";
            leitorToolStripMenuItem.Click += leitorToolStripMenuItem_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadadastroToolStripMenuItem;
        private ToolStripMenuItem empréstimosToolStripMenuItem;
        private ToolStripMenuItem devoluçõesToolStripMenuItem;
        private ToolStripMenuItem leitorToolStripMenuItem;
    }
}
