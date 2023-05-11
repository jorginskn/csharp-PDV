using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using PDV;

  

namespace PDV.cadastro
{

    public partial class FrmFuncionario : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand  cmd;
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            // sql = "INSERT INTO  funcionarios(nome, cpf, endereco, telefone, cargo, data, foto) VALUES (@nome, @endereco, @telefone, @cargo, curDate(), @foto";
            sql = "INSERT INTO funcionarios(nome, cpf, telefone, cargo, endereco, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, @data, curDate(), @foto";
            cmd = new MySqlCommand(sql,con.mySqlConnection);
        }
    }
}
