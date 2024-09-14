using AulaAEDB.Windows.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaAEDB.Windows
{
    public partial class FrmIdioma : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmIdioma()
        {
            InitializeComponent();
        }

        public FrmIdioma(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Idioma.ListaTodos();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIdioma_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmIdioma_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Idiomas";
        }

        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(TxtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LimpaControles()
        {
            TxtId.Text = "";
            TxtNome.Text = "";
            Incluir = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!Valida())
                return;

            Idioma oIdioma = new Idioma
            {
                Nome = TxtNome.Text
            };

            if (Incluir)
            {
                oIdioma.Incluir();
            }
            else
            {
                oIdioma.Id = Convert.ToInt32(TxtId.Text);
                oIdioma.Alterar();
            }

            CarregaGrid();
            LimpaControles();
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Idioma objSelecionado = (Idioma)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    //clicou no botão alterar
                    TxtId.Text = objSelecionado.Id.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtId.Enabled = false;
                    TxtNome.Focus();

                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (Livro.SelecionaLivroPorIdioma(objSelecionado.Id).Count() > 0)
                    {
                        MessageBox.Show("Idioma não pôde ser exluído, pois existem livros cadastrados com este Idioma.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Confirme a Exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            objSelecionado.Excluir();
                            CarregaGrid();
                        }
                    }
                }
            }
        }
    }
}
