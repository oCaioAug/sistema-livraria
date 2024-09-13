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
    public partial class FrmGenero : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmGenero(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }

        public FrmGenero()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Genero.ListaTodos();
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmGenero_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((FrmMenu)this.MdiParent).MnuGenero.Enabled = true;
            //((FrmMenu)this.MdiParent).MnuSGenero.Enabled = true;
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";

        }

        private void FrmGenero_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Gêneros";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaControles()
        {
            int Id;

            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Campo é de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }

            return true;
        }

        private void LimpaControles()
        {
            TxtId.Text = "";
            TxtNome.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                //Incluir um genero na lista
                if (Incluir)
                {
                    Genero oGenero = new Genero
                    {
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        oGenero.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtId.Focus();
                    }

                }
                else
                {
                    //Altera o genero selecionado
                    Genero oGenero = new Genero
                    {
                        Id = int.Parse(TxtId.Text),
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        Genero.Alterar(oGenero);

                        LimpaControles();
                        CarregaGrid();
                        Incluir = true;
                        TxtId.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNome.Focus();
                    }
                }
            }


        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Genero objSelecionado = (Genero)GrdItens.Rows[e.RowIndex].DataBoundItem;
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
                    if (Livro.SelecionaLivroPorGenero(objSelecionado.Id).Count > 0)
                    {
                        MessageBox.Show("Existem livros cadastrados com este gênero.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
