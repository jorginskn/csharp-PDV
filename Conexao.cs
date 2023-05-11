using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

 namespace PDV
{
     class Conexao
    {
        public  string mysqlcon = "SERVER=localhost DATABASE=pdv;UID=root;pwd=; port=;";
        public MySqlConnection mySqlConnection = null;

          public void AbrirConexao()
            {
                try
                {
                    mySqlConnection = new MySqlConnection(mysqlcon);
                    mySqlConnection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão com o Banco de Dados" + ex.Message);
                }
            }
         public void fecharConexao()
            {
                try
                {
                    mySqlConnection= new MySqlConnection(mysqlcon);
                    mySqlConnection.Close();
                    mySqlConnection.Dispose();
                     
  
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Erro de conexão com o Banco de Dados" + ex.Message);
                }
            }
          
    }
}
