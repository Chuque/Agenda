using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda2._0
{

    /*classe para o objeto Banco*/

    class Banco
    {
        private static MySqlConnection conexao;
        private static Banco instance;
        private const string URL = "Server=127.0.0.1;Database=agenda;Uid=root;Pwd=root;";

        public Banco()
        {
        	//instancia conexão
            conexao = new MySqlConnection(URL);
        }

        public static Banco GetInstance()
        {
            //instancia uma nova conexao apenas se ela não estiver instanciada. caso positivo apenas retorna a instancia
            if (instance == null)
                instance = new Banco();

            return instance;
        }
        public MySqlConnection Conectar()
        {
            return conexao;
        }

        public void ExecutarSQL(string query)
        {
			//verifica se a conexão está aberta
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

			//instancia comando do MySQL
            MySqlCommand comm = new MySqlCommand(query, conexao);
            comm.ExecuteNonQuery();

			//fecha conexão
            conexao.Close();
        }
    }
}
