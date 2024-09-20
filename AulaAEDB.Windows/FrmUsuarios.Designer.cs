namespace AulaAEDB.Windows
{
    partial class FrmUsuarios
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
            GrdItens = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            LblId = new Label();
            LblNome = new Label();
            TxtId = new TextBox();
            TxtNome = new TextBox();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            TxtSenha = new TextBox();
            LblSenha = new Label();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Email, BtnAlterar, BtnExcluir });
            GrdItens.Dock = DockStyle.Bottom;
            GrdItens.Location = new Point(0, 127);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(963, 323);
            GrdItens.TabIndex = 0;
            GrdItens.CellClick += GrdItens_CellClick;
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
            Nome.Width = 200;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 200;
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
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(795, 47);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 23);
            BtnSalvar.TabIndex = 3;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(876, 47);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(75, 23);
            BtnFechar.TabIndex = 4;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(20, 30);
            LblId.Name = "LblId";
            LblId.Size = new Size(46, 15);
            LblId.TabIndex = 3;
            LblId.Text = "Código";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(73, 30);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 4;
            LblNome.Text = "Nome";
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(20, 48);
            TxtId.MaxLength = 5;
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(47, 23);
            TxtId.TabIndex = 5;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(73, 48);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(379, 23);
            TxtNome.TabIndex = 0;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(20, 98);
            TxtEmail.MaxLength = 50;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(379, 23);
            TxtEmail.TabIndex = 2;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(20, 80);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 7;
            LblEmail.Text = "Email";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(476, 48);
            TxtSenha.MaxLength = 50;
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(147, 23);
            TxtSenha.TabIndex = 1;
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Location = new Point(476, 30);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(39, 15);
            LblSenha.TabIndex = 9;
            LblSenha.Text = "Senha";
            // 
            // FrmUsuarios
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnFechar;
            ClientSize = new Size(963, 450);
            Controls.Add(TxtSenha);
            Controls.Add(LblSenha);
            Controls.Add(TxtEmail);
            Controls.Add(LblEmail);
            Controls.Add(TxtNome);
            Controls.Add(TxtId);
            Controls.Add(LblNome);
            Controls.Add(LblId);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(GrdItens);
            Name = "FrmUsuarios";
            Text = "Cadastro de Usuários";
            Activated += FrmUsuarios_Activated;
            FormClosed += FrmUsuarios_FormClosed;
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdItens;
        private Button BtnSalvar;
        private Button BtnFechar;
        private Label LblId;
        private Label LblNome;
        private TextBox TxtId;
        private TextBox TxtNome;
        private TextBox TxtEmail;
        private Label LblEmail;
        private TextBox TxtSenha;
        private Label LblSenha;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}