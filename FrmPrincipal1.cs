using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void moviToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirCadastroDeUsuario(object sender, EventArgs e)
        {
            cadastro.FrmFuncionario frmCadastro = new cadastro.FrmFuncionario();
            frmCadastro.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
