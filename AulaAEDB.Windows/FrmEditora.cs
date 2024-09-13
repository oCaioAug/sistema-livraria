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
    public partial class FrmEditora : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmEditora()
        {
            InitializeComponent();
        }

        public FrmEditora(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Editora.ListaTodos();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmEditora_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmEditora_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Editora";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Valida()
        {
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
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

            if (Incluir)
            {
                try
                {
                    Editora oEditora = new Editora();
                    oEditora.Nome = TxtNome.Text;
                    oEditora.Incluir();
                    CarregaGrid();
                    LimpaControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Editora oEditora = Editora.Seleciona(Convert.ToInt32(TxtId.Text));
                    oEditora.Nome = TxtNome.Text;
                    oEditora.Alterar();
                    CarregaGrid();
                    LimpaControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Editora oSelecionado = (Editora)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtId.Text = oSelecionado.Id.ToString();
                    TxtNome.Text = oSelecionado.Nome;
                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (Livro.SelecionaLivroPorEditora(oSelecionado.Id).Count() > 0)
                    {
                        MessageBox.Show("Editora não pode ser excluída, pois já está vinculada a um livro.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja realmente excluir?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                Editora oEditora = Editora.Seleciona(oSelecionado.Id);
                                oEditora.Excluir();
                                CarregaGrid();
                                LimpaControles();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
