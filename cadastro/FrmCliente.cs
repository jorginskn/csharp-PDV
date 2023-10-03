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
using System.Security.Cryptography.X509Certificates;

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
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("O Campo Nome está vazio!");
                txtName.Focus();
                return false;
            }
            if (txtCpf.Text.Trim() == "")
            {
                MessageBox.Show("O Campo CPF está vazio!");
                txtCpf.Focus();
                return false;
            }
            if (txtCargo.Text.Trim() == "")
            {
                MessageBox.Show("O Campo Cargo está vazio!");
                txtCargo.Focus();
                return false;
            }
            if (txtEndereco.Text.Trim() == "")
            {
                MessageBox.Show("O Campo Endereço está vazio!");
                txtEndereco.Focus();
                return false;
            }
            if (txtTelefone.Text.Trim() == "")
            {
                MessageBox.Show("O Campo Telefone está vazio!");
                txtTelefone.Focus();
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
        public void DisableFilds()
        {
            txtName.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtCargo.Enabled = false;
            txtTelefone.Enabled = false;
        }
        public void enableFilds()
        {
            txtName.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            txtCargo.Enabled = true;
            txtTelefone.Enabled = true;
        }
        public void clearFilds()
        {
            txtName.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtTelefone.Text = string.Empty;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            string sql = "UPDATE pdv_cliente SET nome=@nome, cpf=@cpf, endereco=@endereco, telefone=@telefone, cargo=@cargo ";
            cmd = new MySqlCommand(sql, con.conexao);
            cmd.Parameters.AddWithValue("@nome", txtName.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);
            cmd.ExecuteNonQuery();
            con.fecharConexao();
            txtBuscar.Focus();
            clearFilds();
            DisableFilds();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {   
            clearFilds();
            enableFilds();
            txtName.Focus();    
        }
    }
}
