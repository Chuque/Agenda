using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda2._0
{
    class GrupoDAO
    {
        //função que adiciona um novo grupo
        public void AddGrupo(int idUser, int idGrupo, string nomeGrupo)
        {
            string query = string.Format("insert into grupo(idUsuario, idGrupo, nomeGrupo) values({0}, {1}, '{2}');", idUser, idGrupo, nomeGrupo);

            Banco.GetInstance().ExecutarSQL(query);
        }

        //função que deleta o grupo
        public void DeleteGrupo(int idGrupo)
        {
            string query = string.Format("delete from grupo where idGrupo = {0};", idGrupo);

            Banco.GetInstance().ExecutarSQL(query);
        }

        //função que retorna uma lista com todos os grupos do usuario
        public List<Grupo> ListAllFromUser(int idUsuario)
        {
            MySqlConnection conn = Banco.GetInstance().Conectar();

            string query = string.Format("select idgrupo, nomegrupo from grupo where idUsuario = {0};", idUsuario);

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            List<Grupo> grupos = new List<Grupo>();
            Grupo grupo;

            while(dr.Read())
            {
                grupo = new Grupo();
                grupo.IdGrupo = dr.GetInt32("idGrupo");
                grupo.NomeGrupo = dr.GetString("nomeGrupo");
                grupos.Add(grupo);
            }

            conn.Close();

            return grupos;
        }

        //função que retorna um inteiro contendo o id do proximo grupo a ser adicionado
        public int NextId()
        {
            string query = string.Format("select max((idgrupo)+1) as id from grupo;");

            MySqlConnection conn = Banco.GetInstance().Conectar();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            int novoId;

            dr.Read();

            novoId = dr.GetInt32("id");
            
            conn.Close();

            return novoId;
        }
    }
}
