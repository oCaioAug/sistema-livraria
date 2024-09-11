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
    public partial class FrmUsuarios : Form
    {
        ToolStripMenuItem _mnu;

        private bool Incluir = true;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        public FrmUsuarios(ToolStripMenuItem mnu)
        {
            InitializeComponent();
            _mnu = mnu;
        }

        private void FrmUsuarios_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Usuários";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mnu.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Usuario.ListaTodos();
        }

        private bool Valida()
        {
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }
            else if (TxtEmail.Text.Trim() == "")
            {
                MessageBox.Show("E-mail é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.Focus();
                return false;
            }
            else if (TxtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Senha é obrigatória", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSenha.Focus();
                return false;
            }

            return true;
        }

        private void LimpaControles()
        {
            TxtId.Text = "";
            TxtNome.Text = "";
            TxtEmail.Text = "";
            TxtSenha.Text = "";
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!Valida())
                return;

            if (Incluir)
            {
                Usuario oUsuario = new Usuario
                {
                    Nome = TxtNome.Text,
                    Email = TxtEmail.Text,
                    Senha = TxtSenha.Text
                };

                try
                {
                    oUsuario.Incluir();
                    LimpaControles();
                    CarregaGrid();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                Usuario oUsuario = new Usuario
                {
                    Id = Convert.ToInt32(TxtId.Text),
                    Nome = TxtNome.Text,
                    Email = TxtEmail.Text,
                    Senha = TxtSenha.Text
                };

                try
                {
                    oUsuario.Alterar();
                    LimpaControles();
                    CarregaGrid();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Usuario oSelecionado = (Usuario)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtId.Text = oSelecionado.Id.ToString();
                    TxtNome.Text = oSelecionado.Nome;
                    TxtEmail.Text = oSelecionado.Email;
                    TxtSenha.Text = oSelecionado.Senha;
                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Deseja realmente excluir?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Usuario oUsuario = new Usuario
                        {
                            Id = oSelecionado.Id
                        };

                        try
                        {
                            oUsuario.Excluir();
                            CarregaGrid();
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
