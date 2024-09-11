namespace AulaAEDB.Windows
{
    partial class FrmAutor
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
            BtnSalvar = new Button();
            BtnFechar = new Button();
            TxtId = new TextBox();
            TxtNome = new TextBox();
            LblCodigo = new Label();
            LblNome = new Label();
            GrdItens = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(529, 31);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 23);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(650, 31);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(75, 23);
            BtnFechar.TabIndex = 6;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(12, 31);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(48, 23);
            TxtId.TabIndex = 7;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(84, 31);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(393, 23);
            TxtNome.TabIndex = 8;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(14, 9);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 9;
            LblCodigo.Text = "Código";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(84, 9);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 10;
            LblNome.Text = "Nome";
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, BtnAlterar, BtnExcluir });
            GrdItens.Dock = DockStyle.Bottom;
            GrdItens.Location = new Point(0, 114);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(800, 336);
            GrdItens.TabIndex = 11;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Id";
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 200;
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
            // FrmAutor
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnFechar;
            ClientSize = new Size(800, 450);
            Controls.Add(GrdItens);
            Controls.Add(LblNome);
            Controls.Add(LblCodigo);
            Controls.Add(TxtNome);
            Controls.Add(TxtId);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Name = "FrmAutor";
            Text = "Cadastro de Autor";
            Activated += FrmAutor_Activated;
            FormClosed += FrmAutor_FormClosed;
            Load += FrmAutor_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Button BtnSalvar;
        private Button BtnFechar;
        private TextBox TxtId;
        private TextBox TxtNome;
        private Label LblCodigo;
        private Label LblNome;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}