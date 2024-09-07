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
    }
}
