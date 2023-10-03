using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.cadastro
{
    public partial class FrmFuncionario : Form
    {
        Conexao conexao= new Conexao();
        MySqlCommand cmd;
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conexao.AbrirConexao();
            string sql = "INSERT INTO pdv_cliente(nome, telefone, endereco, cpf, cargo) VALUES (@nome, @endereco,@cpf ,@telefone, @cargo)";

        }
    }
}
