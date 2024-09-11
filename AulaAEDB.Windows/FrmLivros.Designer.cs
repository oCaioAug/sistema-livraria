namespace AulaAEDB.Windows
{
    partial class FrmLivros
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
            toolTip1 = new ToolTip(components);
            GrdItens = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            QtdPaginas = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Edicao = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            CmbAutor = new ComboBox();
            TxtId = new TextBox();
            TxtNome = new TextBox();
            TxtISBN = new TextBox();
            TxtDescricao = new TextBox();
            LblAutor = new Label();
            LblId = new Label();
            LblNome = new Label();
            LblDescricao = new Label();
            LblISBN = new Label();
            LblGenero = new Label();
            CmbGenero = new ComboBox();
            LblEditora = new Label();
            CmbEditora = new ComboBox();
            LblIdioma = new Label();
            CmbIdioma = new ComboBox();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            TxtQtdPaginas = new TextBox();
            TxtEdicao = new TextBox();
            LblQtdPaginas = new Label();
            LblEdicao = new Label();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao, QtdPaginas, ISBN, Editora, Idioma, Genero, Autor, Edicao, BtnAlterar, BtnExcluir });
            GrdItens.Dock = DockStyle.Bottom;
            GrdItens.Location = new Point(0, 197);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(1530, 343);
            GrdItens.TabIndex = 0;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellFormatting += GrdItens_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Código";
            Id.Name = "Id";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 250;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            // 
            // QtdPaginas
            // 
            QtdPaginas.DataPropertyName = "QtdPaginas";
            QtdPaginas.HeaderText = "QTD Páginas";
            QtdPaginas.Name = "QtdPaginas";
            // 
            // ISBN
            // 
            ISBN.DataPropertyName = "ISBN";
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            // 
            // Editora
            // 
            Editora.DataPropertyName = "Editora.Nome";
            Editora.HeaderText = "Editora";
            Editora.Name = "Editora";
            // 
            // Idioma
            // 
            Idioma.DataPropertyName = "(Livro)GrdItens.Rows[e.RowIndex].DataBoundItem.Idioma.Nome";
            Idioma.HeaderText = "Idioma";
            Idioma.Name = "Idioma";
            // 
            // Genero
            // 
            Genero.HeaderText = "Gênero";
            Genero.Name = "Genero";
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            // 
            // Edicao
            // 
            Edicao.DataPropertyName = "Edicao";
            Edicao.HeaderText = "Edição";
            Edicao.Name = "Edicao";
            // 
            // BtnAlterar
            // 
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.Name = "BtnAlterar";
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.Name = "BtnExcluir";
            // 
            // CmbAutor
            // 
            CmbAutor.AllowDrop = true;
            CmbAutor.AutoCompleteMode = AutoCompleteMode.Suggest;
            CmbAutor.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbAutor.FormattingEnabled = true;
            CmbAutor.Location = new Point(29, 117);
            CmbAutor.Name = "CmbAutor";
            CmbAutor.Size = new Size(121, 23);
            CmbAutor.TabIndex = 1;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(29, 36);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(46, 23);
            TxtId.TabIndex = 2;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(108, 36);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(386, 23);
            TxtNome.TabIndex = 3;
            // 
            // TxtISBN
            // 
            TxtISBN.Location = new Point(919, 36);
            TxtISBN.MaxLength = 20;
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(156, 23);
            TxtISBN.TabIndex = 4;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(516, 36);
            TxtDescricao.MaxLength = 50;
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(372, 23);
            TxtDescricao.TabIndex = 5;
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.Location = new Point(29, 99);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(37, 15);
            LblAutor.TabIndex = 6;
            LblAutor.Text = "Autor";
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(26, 18);
            LblId.Name = "LblId";
            LblId.Size = new Size(46, 15);
            LblId.TabIndex = 7;
            LblId.Text = "Código";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(108, 18);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(37, 15);
            LblNome.TabIndex = 8;
            LblNome.Text = "Título";
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(516, 18);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(58, 15);
            LblDescricao.TabIndex = 9;
            LblDescricao.Text = "Descrição";
            // 
            // LblISBN
            // 
            LblISBN.AutoSize = true;
            LblISBN.Location = new Point(919, 18);
            LblISBN.Name = "LblISBN";
            LblISBN.Size = new Size(74, 15);
            LblISBN.TabIndex = 10;
            LblISBN.Text = "Código ISBN";
            // 
            // LblGenero
            // 
            LblGenero.AutoSize = true;
            LblGenero.Location = new Point(156, 100);
            LblGenero.Name = "LblGenero";
            LblGenero.Size = new Size(45, 15);
            LblGenero.TabIndex = 12;
            LblGenero.Text = "Gênero";
            // 
            // CmbGenero
            // 
            CmbGenero.FormattingEnabled = true;
            CmbGenero.Location = new Point(156, 118);
            CmbGenero.Name = "CmbGenero";
            CmbGenero.Size = new Size(121, 23);
            CmbGenero.TabIndex = 11;
            // 
            // LblEditora
            // 
            LblEditora.AutoSize = true;
            LblEditora.Location = new Point(283, 99);
            LblEditora.Name = "LblEditora";
            LblEditora.Size = new Size(44, 15);
            LblEditora.TabIndex = 14;
            LblEditora.Text = "Editora";
            // 
            // CmbEditora
            // 
            CmbEditora.FormattingEnabled = true;
            CmbEditora.Location = new Point(283, 117);
            CmbEditora.Name = "CmbEditora";
            CmbEditora.Size = new Size(121, 23);
            CmbEditora.TabIndex = 13;
            // 
            // LblIdioma
            // 
            LblIdioma.AutoSize = true;
            LblIdioma.Location = new Point(410, 100);
            LblIdioma.Name = "LblIdioma";
            LblIdioma.Size = new Size(44, 15);
            LblIdioma.TabIndex = 16;
            LblIdioma.Text = "Idioma";
            // 
            // CmbIdioma
            // 
            CmbIdioma.FormattingEnabled = true;
            CmbIdioma.Location = new Point(410, 118);
            CmbIdioma.Name = "CmbIdioma";
            CmbIdioma.Size = new Size(121, 23);
            CmbIdioma.TabIndex = 15;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(918, 116);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 23);
            BtnSalvar.TabIndex = 17;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(1000, 117);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(75, 23);
            BtnFechar.TabIndex = 18;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // TxtQtdPaginas
            // 
            TxtQtdPaginas.Location = new Point(537, 118);
            TxtQtdPaginas.Name = "TxtQtdPaginas";
            TxtQtdPaginas.Size = new Size(100, 23);
            TxtQtdPaginas.TabIndex = 19;
            // 
            // TxtEdicao
            // 
            TxtEdicao.Location = new Point(643, 118);
            TxtEdicao.Name = "TxtEdicao";
            TxtEdicao.Size = new Size(100, 23);
            TxtEdicao.TabIndex = 20;
            // 
            // LblQtdPaginas
            // 
            LblQtdPaginas.AutoSize = true;
            LblQtdPaginas.Location = new Point(537, 100);
            LblQtdPaginas.Name = "LblQtdPaginas";
            LblQtdPaginas.Size = new Size(71, 15);
            LblQtdPaginas.TabIndex = 21;
            LblQtdPaginas.Text = "Qtd Páginas";
            // 
            // LblEdicao
            // 
            LblEdicao.AutoSize = true;
            LblEdicao.Location = new Point(643, 100);
            LblEdicao.Name = "LblEdicao";
            LblEdicao.Size = new Size(59, 15);
            LblEdicao.TabIndex = 22;
            LblEdicao.Text = "Nº Edição";
            // 
            // FrmLivros
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnFechar;
            ClientSize = new Size(1530, 540);
            Controls.Add(LblEdicao);
            Controls.Add(LblQtdPaginas);
            Controls.Add(TxtEdicao);
            Controls.Add(TxtQtdPaginas);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(LblIdioma);
            Controls.Add(CmbIdioma);
            Controls.Add(LblEditora);
            Controls.Add(CmbEditora);
            Controls.Add(LblGenero);
            Controls.Add(CmbGenero);
            Controls.Add(LblISBN);
            Controls.Add(LblDescricao);
            Controls.Add(LblNome);
            Controls.Add(LblId);
            Controls.Add(LblAutor);
            Controls.Add(TxtDescricao);
            Controls.Add(TxtISBN);
            Controls.Add(TxtNome);
            Controls.Add(TxtId);
            Controls.Add(CmbAutor);
            Controls.Add(GrdItens);
            Name = "FrmLivros";
            Text = "Cadastro de Livro";
            Activated += FrmLivros_Activated;
            FormClosed += FrmLivros_FormClosed;
            Load += FrmLivros_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn QtdPaginas;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn Idioma;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Edicao;
        private ComboBox CmbAutor;
        private TextBox TxtId;
        private TextBox TxtNome;
        private TextBox TxtISBN;
        private TextBox TxtDescricao;
        private Label LblAutor;
        private Label LblId;
        private Label LblNome;
        private Label LblDescricao;
        private Label LblISBN;
        private Label LblGenero;
        private ComboBox CmbGenero;
        private Label LblEditora;
        private ComboBox CmbEditora;
        private Label LblIdioma;
        private ComboBox CmbIdioma;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
        private Button BtnSalvar;
        private Button BtnFechar;
        private TextBox TxtQtdPaginas;
        private TextBox TxtEdicao;
        private Label LblQtdPaginas;
        private Label LblEdicao;
    }
}