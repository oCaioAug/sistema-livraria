namespace AulaAEDB.Windows
{
    partial class Form1
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
            BtnMensagem = new Button();
            LblMensagem = new Label();
            BtnMudarCorFundoForm = new Button();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            textBox1 = new TextBox();
            BtnMensagemBox = new Button();
            SuspendLayout();
            // 
            // BtnMensagem
            // 
            BtnMensagem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnMensagem.BackColor = Color.FromArgb(255, 128, 0);
            BtnMensagem.BackgroundImageLayout = ImageLayout.None;
            BtnMensagem.Location = new Point(12, 89);
            BtnMensagem.Name = "BtnMensagem";
            BtnMensagem.Size = new Size(776, 49);
            BtnMensagem.TabIndex = 0;
            BtnMensagem.Text = "Minha Primeira Mensagem";
            BtnMensagem.UseVisualStyleBackColor = false;
            BtnMensagem.Click += BtnMensagem_Click;
            // 
            // LblMensagem
            // 
            LblMensagem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblMensagem.BackColor = SystemColors.Control;
            LblMensagem.Location = new Point(12, 35);
            LblMensagem.Name = "LblMensagem";
            LblMensagem.Size = new Size(776, 36);
            LblMensagem.TabIndex = 1;
            // 
            // BtnMudarCorFundoForm
            // 
            BtnMudarCorFundoForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnMudarCorFundoForm.BackColor = Color.FromArgb(255, 128, 0);
            BtnMudarCorFundoForm.BackgroundImageLayout = ImageLayout.None;
            BtnMudarCorFundoForm.Location = new Point(12, 144);
            BtnMudarCorFundoForm.Name = "BtnMudarCorFundoForm";
            BtnMudarCorFundoForm.Size = new Size(776, 49);
            BtnMudarCorFundoForm.TabIndex = 2;
            BtnMudarCorFundoForm.Text = "Mudar Cor";
            BtnMudarCorFundoForm.UseVisualStyleBackColor = false;
            BtnMudarCorFundoForm.Click += BtnMudarCorFundoForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 240);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Menssagem";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 272);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 23);
            textBox1.TabIndex = 4;
            // 
            // BtnMensagemBox
            // 
            BtnMensagemBox.Location = new Point(12, 313);
            BtnMensagemBox.Name = "BtnMensagemBox";
            BtnMensagemBox.Size = new Size(112, 41);
            BtnMensagemBox.TabIndex = 5;
            BtnMensagemBox.Text = "Exbir Mensagem";
            BtnMensagemBox.UseVisualStyleBackColor = true;
            BtnMensagemBox.Click += BtnMensagemBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnMensagemBox);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BtnMudarCorFundoForm);
            Controls.Add(LblMensagem);
            Controls.Add(BtnMensagem);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMensagem;
        private Label LblMensagem;
        private Button BtnMudarCorFundoForm;
        private ColorDialog colorDialog1;
        private Label label1;
        private TextBox textBox1;
        private Button BtnMensagemBox;
    }
}
