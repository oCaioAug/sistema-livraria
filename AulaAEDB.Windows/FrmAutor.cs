using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AulaAEDB.Windows.Model;

namespace AulaAEDB.Windows
{
    public partial class FrmAutor : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmAutor(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }

        public FrmAutor()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Autor.ListaTodos();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmAutor_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Autores";
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
                MessageBox.Show("Nome do autor é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }
            //else if (TxtId.Text.Trim() == "")
            //{
            //    MessageBox.Show("O código é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtId.Focus();
            //    return false;
            //}
            //else if (!int.TryParse(TxtId.Text, out Id))
            //{
            //    MessageBox.Show("Código inválido", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtId.Focus();
            //    return false;
            //}

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
            if (ValidaControles())
            {
                if (Incluir)
                {
                    //Incluir Autor na lista
                    Autor oAutor = new Autor
                    {
                        //Id = int.Parse(TxtId.Text),
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        oAutor.Incluir();
                        //MessageBox.Show("Autor incluído com sucesso", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaControles();
                        CarregaGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Alterar Autor na lista
                    Autor oAutor = new Autor
                    {
                        Id = int.Parse(TxtId.Text),
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        Autor.Alterar(oAutor);
                        //MessageBox.Show("Autor alterado com sucesso", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaControles();
                        CarregaGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Autor objSelecionado = (Autor)GrdItens.Rows[e.RowIndex].DataBoundItem;
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
