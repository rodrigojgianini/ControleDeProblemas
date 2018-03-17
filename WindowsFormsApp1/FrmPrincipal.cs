using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTipo().Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void cadastroNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNivel().Show();
        }
    }
}
