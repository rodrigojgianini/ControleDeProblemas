using Entidade;
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
    public partial class FrmTipo : Form
    {
        public FrmTipo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
            tipo.Id = Convert.ToInt32(txtId.Text);
            tipo.Descricao = txtDescricao.Text;
            

            MessageBox.Show("Olá turma!\n\n" + tipo);
        }
    }
}
