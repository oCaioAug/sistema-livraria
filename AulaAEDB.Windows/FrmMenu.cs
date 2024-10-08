﻿using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MnuGenero_Click(object sender, EventArgs e)
        {
            FrmGenero oFrmGenero = new FrmGenero(MnuGenero, MnuSGenero);
            oFrmGenero.MdiParent = this;
            MnuGenero.Enabled = false;
            MnuSGenero.Enabled = false;
            oFrmGenero.Show();
        }

        private void MnuSGenero_Click(object sender, EventArgs e)
        {
            MnuGenero_Click(sender, e);
        }

        private void MnuAula01_Click(object sender, EventArgs e)
        {
            Form1 oForm1 = new Form1();
            oForm1.MdiParent = this;
            oForm1.Show();
        }

        private void MnuAutor_Click(object sender, EventArgs e)
        {
            FrmAutor oFrmAutor = new FrmAutor(MnuAutor, MnuSAutor);
            oFrmAutor.MdiParent = this;
            MnuAutor.Enabled = false;
            MnuSAutor.Enabled = false;
            oFrmAutor.Show();
        }

        private void MnuSAutor_Click(object sender, EventArgs e)
        {
            MnuAutor_Click(sender, e);
        }

        private void MnuEditora_Click(object sender, EventArgs e)
        {
            FrmEditora oFrmEditora = new FrmEditora(MnuEditora, MnuSEditora);
            oFrmEditora.MdiParent = this;
            MnuEditora.Enabled = false;
            MnuSEditora.Enabled = false;
            oFrmEditora.Show();
        }

        private void MnuSEditora_Click(object sender, EventArgs e)
        {
            MnuEditora_Click(sender, e);
        }

        private void MnuIdioma_Click(object sender, EventArgs e)
        {
            FrmIdioma oFrmIdioma = new FrmIdioma(MnuIdioma, MnuSIdioma);
            oFrmIdioma.MdiParent = this;
            MnuIdioma.Enabled = false;
            MnuSIdioma.Enabled = false;
            oFrmIdioma.Show();
        }

        private void MnuSIdioma_Click(object sender, EventArgs e)
        {
            MnuIdioma_Click(sender, e);
        }

        private void MnuLivro_Click(object sender, EventArgs e)
        {
            FrmLivros oFrmLivros = new FrmLivros(MnuLivro, MnuSLivro);
            oFrmLivros.MdiParent = this;
            MnuLivro.Enabled = false;
            MnuSLivro.Enabled = false;
            oFrmLivros.Show();
        }

        private void MnuSLivro_Click(object sender, EventArgs e)
        {
            MnuLivro_Click(sender, e);
        }

        private void MnuUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios oFrmUsuarios = new FrmUsuarios(MnuUsuarios);
            oFrmUsuarios.MdiParent = this;
            MnuUsuarios.Enabled = false;
            oFrmUsuarios.Show();
        }
    }
}
