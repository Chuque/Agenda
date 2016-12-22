using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda2._0
{
    class TelefoneDAO
    {
        public List<Telefone> ListAll(int idContato)
        {
            //conecta ao banco
            MySqlConnection conn = Banco.GetInstance().Conectar();
            
            string query = string.Format("select nroTelefone, idContato from telefone where idContato = {0};", idContato);
            //verifica estado da conexão para abrir 
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            Telefone telefone;

            List<Telefone> telefones = new List<Telefone>();

			
            while(dr.Read())
            {
                telefone = new Telefone();
               	//captura o nroTelefone do banco e atribui para NroTelefone de telefone
                telefone.NroTelefone = dr.GetString("nroTelefone");               
              	//captura o idContato do banco e atribui para idContato de telefone
                telefone.IdContato = dr.GetInt32("idContato");
                telefones.Add(telefone);
            }
            
            conn.Close(); 

            return telefones;
        }

        //função que remove os telefones de um contato
        public void RemoverTelefones(int idContato)
        {
            //MySqlConnection conn = Banco.GetInstance().Conectar();

            string query = string.Format("delete from telefone where idContato = {0};", idContato);

			//executa query SQL
            Banco.GetInstance().ExecutarSQL(query);
        }

        public void AdicionarTelefones(int idContato, List<Telefone> telefones)
        {

			//percorre elementos de telefones
            foreach(Telefone telefone in telefones)
            {
				//executa query SQL
                string query = string.Format("insert into telefone(nroTelefone, idContato) values('{0}', {1});", telefone.NroTelefone, idContato);
                Banco.GetInstance().ExecutarSQL(query);
            }
        }

        //função que atualiza os telefones de um contato
        public void AtualizarTelefones(int idContato, List<Telefone> telefones)
        {
            RemoverTelefones(idContato);

            foreach (Telefone telefone in telefones)
            {
				//executa query SQL
                string query = string.Format("insert into telefone(nroTelefone, idContato) values('{0}', {1});", telefone.NroTelefone, idContato);
                Banco.GetInstance().ExecutarSQL(query);
            }
        }
    }
}
