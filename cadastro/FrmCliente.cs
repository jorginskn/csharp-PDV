using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV;
using MySql.Data.MySqlClient;
namespace PDV.cadastro
{

    public partial class FrmCliente : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmCliente()
        {
            InitializeComponent();

        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private bool validationForm()
        {
            if (txtName.Text == "" || txtCpf.Text == "" || txtCargo.Text == "" || txtEndereco.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Existem Campos vazios!");
                return false;
            }
            else
            {
                return true;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validationForm())
            {
                con.AbrirConexao();
                string sql = "INSERT INTO pdv_cliente(nome, telefone, endereco, cpf, cargo) VALUES (@nome, @endereco,@cpf ,@telefone, @cargo)";
                cmd = new MySqlCommand(sql, con.conexao);
                cmd.Parameters.AddWithValue("@nome", txtName.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);
                cmd.ExecuteNonQuery();
                con.fecharConexao();

            }





        }
    }
}
