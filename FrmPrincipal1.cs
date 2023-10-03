using MySqlConnector;
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

         

        private void buttonSair(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenCustomerRegistration(object sender, EventArgs e)
        {
            cadastro.FrmCliente frmCadastro = new cadastro.FrmCliente();
            frmCadastro.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void OpenEmployeeRegistration(object sender, EventArgs e)
        {
            cadastro.FrmFuncionario frm = new cadastro.FrmFuncionario();
            frm.ShowDialog();
        }
    }
}
