using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda2._0
{
    class ContatoDAO
    {
        //adiciona um contato, seus telefones e seus grupos
        public void AddContato(Contato contato, List<Telefone> telefones, List<int>idGrupos)
        {
            string qry = string.Format("insert into contato (idUsuario, nomeContato, logradouro, numero, bairro, cidade, estado, anotacoes)"+
                                        "values ({0},'{1}','{2}',{3},'{4}','{5}','{6}','{7}');", 
                                        contato.IdUsuario, contato.NomeContato, contato.Logradouro, contato.Numero, contato.Bairro, contato.Cidade, contato.Estado, contato.Anotacoes);

            Banco.GetInstance().ExecutarSQL(qry);

            TelefoneDAO telefoneDao = new TelefoneDAO();
            telefoneDao.AdicionarTelefones(contato.IdContato, telefones);

            PertenceDAO grupoDao = new PertenceDAO();

            grupoDao.AddPertence(contato.IdContato, idGrupos);
        }

        //remove um contato
        public void RemoverContato(int idContato)
        {
            string query = string.Format("delete from contato where idContato = {0};", idContato);

            Banco.GetInstance().ExecutarSQL(query);
        }

        //atualiza um contato, seus grupos e telefones
        public void AtualizarContato(Contato Contato, List<Telefone> telefones, List<int> idGrupos)
        {
            string query = string.Format("update contato set nomeContato = '{0}', logradouro = '{1}', numero = {2}, bairro = '{3}', cidade = '{4}', estado = '{5}', anotacoes = '{6}'" +
                            "where idContato = {7};", Contato.NomeContato, Contato.Logradouro, Contato.Numero, Contato.Bairro, Contato.Cidade, Contato.Estado, Contato.Anotacoes, Contato.IdContato);

            Banco.GetInstance().ExecutarSQL(query);

            TelefoneDAO telefoneDao = new TelefoneDAO();

            telefoneDao.AtualizarTelefones(Contato.IdContato, telefones);

            PertenceDAO pertenceDao = new PertenceDAO();

            pertenceDao.Atualiza(idGrupos, Contato.IdContato);
        }

        //retorna uma lista de contatos filtrados por nome e grupo. se grupo == 0 retorna todos os contatos e grupos
        public List<Contato> ListByName(string nome, int idGrupo, int idUser)
        {
            MySqlConnection conn = Banco.GetInstance().Conectar();
            string query;

            if(idGrupo == 0)
                query = string.Format("select idContato, nomeContato, logradouro, numero, bairro, cidade, estado, anotacoes from contato where nomecontato like '%{0}%' and idUsuario = {1} order by nomeContato;", nome, idUser);
            else
                query = string.Format("select idContato, nomeContato, logradouro, numero, bairro, cidade, estado, anotacoes from contato where nomecontato like '%{0}%' and idContato in (select idContato from Pertence where idGrupo in (select idgrupo from grupo where idGrupo = {1})) and idUsuario = {2} order by nomeContato;", nome, idGrupo, idUser);
			//abre conexao
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);

			//executa reader
            MySqlDataReader dr = comm.ExecuteReader();

            Contato contato;
            List<Contato> contatos = new List<Contato>();
            
            while(dr.Read())
            {
            	//atribuir valores do banco ao contato
                contato = new Contato();
                contato.IdContato = dr.GetInt32("IdContato");
                contato.NomeContato = dr.GetString("nomeContato");
                contato.Logradouro = dr.GetString("logradouro");
                contato.Numero = dr.GetInt32("numero");
                contato.Bairro = dr.GetString("bairro");
                contato.Cidade = dr.GetString("cidade");
                contato.Estado = dr.GetString("estado");
				
				//verifica se as anotações está nulo
                if (dr.IsDBNull(7))
                    contato.Anotacoes = "";
                else
                    contato.Anotacoes = dr.GetString("anotacoes");
                contatos.Add(contato);
            }

            conn.Close();

            return contatos;
        }

        //retorna todos os contatos de um usuario
        public List<Contato> ListAll(int idGrupo, int idUser)
        {
            MySqlConnection conn = Banco.GetInstance().Conectar();
            
            string query;

            if (idGrupo == 0)
                query = string.Format("select idContato, nomeContato, logradouro, numero, bairro, cidade, estado, anotacoes from contato where idUsuario = {0} order by nomeContato;", idUser);
            else
                query = string.Format("select idContato, nomeContato, logradouro, numero, bairro, cidade, estado, anotacoes from contato where idContato in (select idContato from Pertence where idGrupo = {0}) and idUsuario = {1} order by nomeContato;", idGrupo, idUser);

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            
            MySqlDataReader dr = comm.ExecuteReader();
            
            List<Contato> contatos = new List<Contato>();

            while (dr.Read())
            {
               	//atribuir valores do banco ao contato
                Contato contato = new Contato();
                contato.IdContato = dr.GetInt32("IdContato");
                contato.NomeContato = dr.GetString("nomeContato");
                contato.Logradouro = dr.GetString("logradouro");
                contato.Numero = dr.GetInt32("numero");
                contato.Bairro = dr.GetString("bairro");
                contato.Cidade = dr.GetString("cidade");
                contato.Estado = dr.GetString("estado");

				//verifica se anotações está nulo
                if (dr.IsDBNull(7))
                    contato.Anotacoes = "";
                else
                    contato.Anotacoes = dr.GetString("anotacoes");

                contatos.Add(contato);
            }

            conn.Close();

            return contatos;
        }

        //retorna o proximo id a ser inserido no banco. é necessario para adicionar o contato a seus grupos
        public int GetNextId()
        {
            MySqlConnection conn = Banco.GetInstance().Conectar();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string query = "select (max(idcontato)+1) from contato";

            MySqlCommand comm = new MySqlCommand(query, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            int nextId;

            dr.Read();
            nextId = dr.GetInt32(0);

            conn.Close();

            return nextId;
        }
    }
}
