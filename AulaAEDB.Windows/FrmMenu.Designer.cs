namespace AulaAEDB.Windows
{
    partial class FrmMenu
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            MnuLivro = new ToolStripMenuItem();
            MnuGenero = new ToolStripMenuItem();
            MnuAutor = new ToolStripMenuItem();
            MnuEditora = new ToolStripMenuItem();
            MnuIdioma = new ToolStripMenuItem();
            MnuSair = new ToolStripMenuItem();
            aulasToolStripMenuItem = new ToolStripMenuItem();
            MnuAula01 = new ToolStripMenuItem();
            MenuSuspenso = new ContextMenuStrip(components);
            MnuSGenero = new ToolStripMenuItem();
            MnuSAutor = new ToolStripMenuItem();
            MnuSEditora = new ToolStripMenuItem();
            MnuSIdioma = new ToolStripMenuItem();
            MnuSLivro = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblDisplay = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            MenuSuspenso.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, aulasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(913, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuLivro, MnuGenero, MnuAutor, MnuEditora, MnuIdioma, MnuSair });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // MnuLivro
            // 
            MnuLivro.Name = "MnuLivro";
            MnuLivro.Size = new Size(112, 22);
            MnuLivro.Text = "&Livro";
            MnuLivro.Click += MnuLivro_Click;
            // 
            // MnuGenero
            // 
            MnuGenero.Name = "MnuGenero";
            MnuGenero.Size = new Size(112, 22);
            MnuGenero.Text = "&Genero";
            MnuGenero.Click += MnuGenero_Click;
            // 
            // MnuAutor
            // 
            MnuAutor.Name = "MnuAutor";
            MnuAutor.Size = new Size(112, 22);
            MnuAutor.Text = "&Autor";
            MnuAutor.Click += MnuAutor_Click;
            // 
            // MnuEditora
            // 
            MnuEditora.Name = "MnuEditora";
            MnuEditora.Size = new Size(112, 22);
            MnuEditora.Text = "&Editora";
            MnuEditora.Click += MnuEditora_Click;
            // 
            // MnuIdioma
            // 
            MnuIdioma.Name = "MnuIdioma";
            MnuIdioma.Size = new Size(112, 22);
            MnuIdioma.Text = "&Idioma";
            MnuIdioma.Click += MnuIdioma_Click;
            // 
            // MnuSair
            // 
            MnuSair.Name = "MnuSair";
            MnuSair.Size = new Size(112, 22);
            MnuSair.Text = "Sai&r";
            MnuSair.Click += MnuSair_Click;
            // 
            // aulasToolStripMenuItem
            // 
            aulasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuAula01 });
            aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            aulasToolStripMenuItem.Size = new Size(48, 20);
            aulasToolStripMenuItem.Text = "&Aulas";
            // 
            // MnuAula01
            // 
            MnuAula01.Name = "MnuAula01";
            MnuAula01.Size = new Size(110, 22);
            MnuAula01.Text = "Aula01";
            MnuAula01.Click += MnuAula01_Click;
            // 
            // MenuSuspenso
            // 
            MenuSuspenso.Items.AddRange(new ToolStripItem[] { MnuSGenero, MnuSAutor, MnuSEditora, MnuSIdioma, MnuSLivro });
            MenuSuspenso.Name = "MenuSuspenso";
            MenuSuspenso.Size = new Size(181, 136);
            // 
            // MnuSGenero
            // 
            MnuSGenero.Name = "MnuSGenero";
            MnuSGenero.Size = new Size(180, 22);
            MnuSGenero.Text = "&Genero";
            MnuSGenero.Click += MnuSGenero_Click;
            // 
            // MnuSAutor
            // 
            MnuSAutor.Name = "MnuSAutor";
            MnuSAutor.Size = new Size(180, 22);
            MnuSAutor.Text = "&Autor";
            MnuSAutor.Click += MnuSAutor_Click;
            // 
            // MnuSEditora
            // 
            MnuSEditora.Name = "MnuSEditora";
            MnuSEditora.Size = new Size(180, 22);
            MnuSEditora.Text = "&Editora";
            MnuSEditora.Click += MnuSEditora_Click;
            // 
            // MnuSIdioma
            // 
            MnuSIdioma.Name = "MnuSIdioma";
            MnuSIdioma.Size = new Size(180, 22);
            MnuSIdioma.Text = "&Idioma";
            MnuSIdioma.Click += MnuSIdioma_Click;
            // 
            // MnuSLivro
            // 
            MnuSLivro.Name = "MnuSLivro";
            MnuSLivro.Size = new Size(180, 22);
            MnuSLivro.Text = "&Livro";
            MnuSLivro.Click += MnuSLivro_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblDisplay });
            statusStrip1.Location = new Point(0, 490);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(913, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = false;
            LblDisplay.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(200, 17);
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 512);
            ContextMenuStrip = MenuSuspenso;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MenuSuspenso.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem MnuSair;
        public MenuStrip menuStrip1;
        public ContextMenuStrip MenuSuspenso;
        public ToolStripMenuItem MnuGenero;
        public ToolStripMenuItem MnuSGenero;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel LblDisplay;
        private ToolStripMenuItem aulasToolStripMenuItem;
        private ToolStripMenuItem MnuAula01;
        private ToolStripMenuItem MnuAutor;
        private ToolStripMenuItem MnuSAutor;
        private ToolStripMenuItem MnuEditora;
        private ToolStripMenuItem MnuSEditora;
        private ToolStripMenuItem MnuIdioma;
        private ToolStripMenuItem MnuSIdioma;
        private ToolStripMenuItem MnuLivro;
        private ToolStripMenuItem MnuSLivro;
    }
}