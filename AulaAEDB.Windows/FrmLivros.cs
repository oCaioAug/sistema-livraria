using AulaAEDB.Windows.Control;
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
    public partial class FrmLivros : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmLivros()
        {
            InitializeComponent();
        }

        public FrmLivros(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Livro.ListaTodos();
        }

        private void CarregaCombo()
        {
            List<Autor> oAutores = Model.Autor.ListaTodos();
            List<Genero> oGeneros = Model.Genero.ListaTodos();
            List<Editora> oEditoras = Model.Editora.ListaTodos();
            List<Idioma> oIdiomas = Model.Idioma.ListaTodos();

            CmbAutor.Items.Clear();
            CmbAutor.DataSource = oAutores;
            CmbAutor.DisplayMember = "Nome";
            CmbAutor.ValueMember = "Id";

            CmbGenero.Items.Clear();
            CmbGenero.DataSource = oGeneros;
            CmbGenero.DisplayMember = "Nome";
            CmbGenero.ValueMember = "Id";

            CmbEditora.Items.Clear();
            CmbEditora.DataSource = oEditoras;
            CmbEditora.DisplayMember = "Nome";
            CmbEditora.ValueMember = "Id";

            CmbIdioma.Items.Clear();
            CmbIdioma.DataSource = oIdiomas;
            CmbIdioma.DisplayMember = "Nome";
            CmbIdioma.ValueMember = "Id";
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaCombo();
        }

        private void FrmLivros_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmLivros_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Livros";
        }

        private void GrdItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Livro oLivroSelecionado = (Livro)GrdItens.Rows[e.RowIndex].DataBoundItem as Livro;

            if (GrdItens.Columns[e.ColumnIndex].Name == "Editora")
            {

                if (oLivroSelecionado != null && oLivroSelecionado.Editora != null)
                {
                    e.Value = oLivroSelecionado.Editora.Nome;
                }
            }

            if (GrdItens.Columns[e.ColumnIndex].Name == "Idioma")
            {

                if (oLivroSelecionado != null && oLivroSelecionado.Idioma != null)
                {
                    e.Value = oLivroSelecionado.Idioma.Nome;
                }
            }

            if (GrdItens.Columns[e.ColumnIndex].Name == "Genero")
            {

                if (oLivroSelecionado != null && oLivroSelecionado.Genero != null)
                {
                    e.Value = oLivroSelecionado.Genero.Nome;
                }
            }

            if (GrdItens.Columns[e.ColumnIndex].Name == "Autor")
            {

                if (oLivroSelecionado != null && oLivroSelecionado.Autor != null)
                {
                    e.Value = oLivroSelecionado.Autor.Nome;
                }
            }
        }

        private void LimpaControles()
        {
            TxtId.Text = "";
            TxtNome.Text = "";
            TxtDescricao.Text = "";
            TxtISBN.Text = "";
            TxtQtdPaginas.Text = "";
            TxtEdicao.Text = "";
            CmbAutor.SelectedIndex = -1;
            CmbEditora.SelectedIndex = -1;
            CmbGenero.SelectedIndex = -1;
            CmbIdioma.SelectedIndex = -1;
            Incluir = true;
        }

        private bool Valida()
        {
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }
            else if (TxtISBN.Text.Trim() == "")
            {
                MessageBox.Show("ISBN do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtISBN.Focus();
                return false;
            }
            else if (TxtQtdPaginas.Text.Trim() == "")
            {
                MessageBox.Show("Quantidade de páginas do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtQtdPaginas.Focus();
                return false;
            }
            else if (TxtEdicao.Text.Trim() == "")
            {
                MessageBox.Show("Edição do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEdicao.Focus();
                return false;
            }
            else if (CmbAutor.SelectedIndex == -1)
            {
                MessageBox.Show("Autor do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbAutor.Focus();
                return false;
            }
            else if (CmbEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Editora do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbEditora.Focus();
                return false;
            }
            else if (CmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Gênero do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbGenero.Focus();
                return false;
            }
            else if (CmbIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Idioma do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbIdioma.Focus();
                return false;
            }

            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!Valida())
                return;

            if (Incluir)
            {
                Livro oLivro = new Livro
                {
                    Autor = (Autor)CmbAutor.SelectedItem,
                    Editora = (Editora)CmbEditora.SelectedItem,
                    Genero = (Genero)CmbGenero.SelectedItem,
                    Idioma = (Idioma)CmbIdioma.SelectedItem,
                    Nome = TxtNome.Text,
                    Descricao = TxtDescricao.Text,
                    ISBN = TxtISBN.Text,
                    QtdPaginas = Convert.ToInt32(TxtQtdPaginas.Text),
                    Edicao = Convert.ToInt32(TxtEdicao.Text)
                };

                try
                {
                    oLivro.Incluir();
                    LimpaControles();
                    CarregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                Livro oLivro = new Livro
                {
                    Id = Convert.ToInt32(TxtId.Text),
                    Autor = (Autor)CmbAutor.SelectedItem,
                    Editora = (Editora)CmbEditora.SelectedItem,
                    Genero = (Genero)CmbGenero.SelectedItem,
                    Idioma = (Idioma)CmbIdioma.SelectedItem,
                    Nome = TxtNome.Text,
                    Descricao = TxtDescricao.Text,
                    ISBN = TxtISBN.Text,
                    QtdPaginas = Convert.ToInt32(TxtQtdPaginas.Text),
                    Edicao = Convert.ToInt32(TxtEdicao.Text)
                };

                try
                {
                    Livro.Alterar(oLivro);
                    LimpaControles();
                    CarregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Livro oLivroSelecionado = (Livro)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtId.Text = oLivroSelecionado.Id.ToString();
                    TxtNome.Text = oLivroSelecionado.Nome;
                    TxtDescricao.Text = oLivroSelecionado.Descricao;
                    TxtISBN.Text = oLivroSelecionado.ISBN;
                    TxtQtdPaginas.Text = oLivroSelecionado.QtdPaginas.ToString();
                    TxtEdicao.Text = oLivroSelecionado.Edicao.ToString();
                    CmbAutor.SelectedValue = oLivroSelecionado.Autor.Id;
                    CmbEditora.SelectedValue = oLivroSelecionado.Editora.Id;
                    CmbGenero.SelectedValue = oLivroSelecionado.Genero.Id;
                    CmbIdioma.SelectedValue = oLivroSelecionado.Idioma.Id;

                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Deseja realmente excluir o livro selecionado?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Livro.Excluir(oLivroSelecionado.Id);
                            CarregaGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                Incluir = false;
            }
        }
    }
}
