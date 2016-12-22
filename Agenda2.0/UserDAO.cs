using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda2._0
{
    class UserDAO
    {
        //adiciona um novo usuario
        public bool AddUser(string user, string senha)
        {
            MySqlConnection conexao = Banco.GetInstance().Conectar();            

			//abre conexao
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

			//executa query
            string qry = string.Format("select count(login) from usuario where login='{0}';", user);
            MySqlCommand comm = new MySqlCommand(qry, conexao);

            MySqlDataReader dr = comm.ExecuteReader();

            dr.Read();
            int verificador = dr.GetInt32(0);

            conexao.Close();

            if (verificador > 0)
                return false;

			//executa query
            qry = string.Format("insert into usuario (login,senha) values ('{0}','{1}');", user, senha);
            Banco database = Banco.GetInstance();
            database.ExecutarSQL(qry);
            return true;
        }

        //retorna id do usuario caso senha e usuario combinem
        public int Logar(string user, string senha)
        {
        	//conecta
            MySqlConnection conexao = Banco.GetInstance().Conectar();
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
			//executa query
            string qry = string.Format("select count(login) from usuario where login='{0}';", user);
            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            int verificador = dr.GetInt32(0);

            conexao.Close();

            if (verificador == 0)
                return 0;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            qry = string.Format("select count(idUsuario) from usuario where login='{0}' and senha='{1}';", user, senha);
            comm = new MySqlCommand(qry, conexao);
            dr = comm.ExecuteReader();
            dr.Read();
            verificador = dr.GetInt32(0);

            conexao.Close();

            if (verificador > 0)
            {
                if (conexao.State != System.Data.ConnectionState.Open)
                    conexao.Open();

                qry = string.Format("select idUsuario from usuario where login='{0}' and senha='{1}';", user, senha);
                comm = new MySqlCommand(qry, conexao);
                dr = comm.ExecuteReader();
                dr.Read();
                int id = dr.GetInt32(0);

                conexao.Close();
                return id;
            }
            else
                return -1;
        }
    }
}
