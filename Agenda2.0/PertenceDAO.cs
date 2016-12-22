using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda2._0
{
    class PertenceDAO
    {
        //Adiciona um contato aos grupos(na tabela Pertence)
        public void AddPertence(int idContato, List<int> idGrupos)
        {
            string query;

            foreach(int idGrupo in idGrupos)
            {
                query = string.Format("insert into Pertence (idContato, idGrupo) values ({0}, {1});", idContato, idGrupo);
                Banco.GetInstance().ExecutarSQL(query);
            }
        }
        
        //Remove um contato de todos os grupos inseridos(tabela Pertence)
        public void RmvContato(int idContato)
        {
            string query = string.Format("delete from Pertence where idContato = {0}", idContato);

            Banco.GetInstance().ExecutarSQL(query);
        }

        //retorna uma lista de inteiros com o codigo dos grupos que o contato está inserido
        public List<int> ListGruposInseridos(int idContato)
        {
            string query = string.Format("select idGrupo from Pertence where idContato = {0}", idContato);

            MySqlConnection conn = Banco.GetInstance().Conectar();
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            List<int> gruposInseridos = new List<int>();

            while(dr.Read())
            {
                int grupo = dr.GetInt32("idgrupo");
                gruposInseridos.Add(grupo);
            }

            conn.Close();

            return gruposInseridos;
        }

        //função que recebe uma string contendo nomes de grupos e retorna seus respectivos ids
        public List<int> IdGrupos(List<string> nomeGrupos, int idUsuario)
        {
            MySqlConnection conn = Banco.GetInstance().Conectar();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string query;

            List<int> idGrupos = new List<int>();

            foreach (string nomeGrupo in nomeGrupos)
            {
                query = string.Format("select idGrupo from grupo where nomegrupo = '{0}' and idusuario = {1};", nomeGrupo, idUsuario);

                MySqlCommand comm = new MySqlCommand(query, conn);
                
                MySqlDataReader dr = comm.ExecuteReader();
                                
                if(dr.Read())
                    idGrupos.Add(dr.GetInt32("idGrupo"));

                dr.Close();
                
            }
            conn.Close();

            return idGrupos;
        }

        //função que atualiza os grupos a qual um contato pertence
        public void Atualiza(List<int> idGrupos, int idContato)
        {
            string query = string.Format("delete from Pertence where idContato = {0};", idContato);
            Banco.GetInstance().ExecutarSQL(query);

            foreach (int idGrupo in idGrupos)
            {
                //executa query SQL
                query = string.Format("insert into Pertence(idContato, idGrupo) values('{0}', {1});",idContato , idGrupo);
                Banco.GetInstance().ExecutarSQL(query);
            }
        }
    }
}
