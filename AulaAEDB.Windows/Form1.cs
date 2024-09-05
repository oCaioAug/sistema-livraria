namespace AulaAEDB.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnMensagem_Click(object sender, EventArgs e)
        {
            if (LblMensagem.Text.Trim() == "")
            {
                LblMensagem.Text = "Olá, Mundo!";
                LblMensagem.BackColor = Color.Blue;
            }
            else
            {
                LblMensagem.Text = "Bananão";
                LblMensagem.BackColor = Color.Yellow;
            }
        }

        private void BtnMudarCorFundoForm_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.AliceBlue;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void BtnMensagemBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text, "Minha Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Primeira Marabilhosa aula";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }
    }
}
