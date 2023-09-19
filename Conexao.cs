using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PDV
{
    class Conexao
    {

        string conection = "DATABASE=projetopdv; SERVER=localhost; port=3306; UID=root;pwd='1234567'";
      public  MySqlConnection conexao;
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conection);
                conexao.Open(); 
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro de conexão com o Banco de Dados" + ex.Message);
                return;
            }
        }
        public void fecharConexao()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados" + ex.Message);
            }
        }

    }
}
