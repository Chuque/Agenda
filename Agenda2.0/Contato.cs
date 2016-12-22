using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda2._0
{

    /* classe para o objeto Contato*/
    class Contato
    {
        private int idUsuario;
        private int idContato;
        private string nomeContato;
        private string logradouro;
        private int numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string anotacoes;

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public int IdContato
        {
            get
            {
                return idContato;
            }

            set
            {
                idContato = value;
            }
        }

        public string NomeContato
        {
            get
            {
                return nomeContato;
            }

            set
            {
                if (value == null)
                    nomeContato = "";
                else
                    nomeContato = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return logradouro;
            }

            set
            {
                if (value == null)
                    logradouro = "";
                else
                    logradouro = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                if (value == null)
                    bairro = "";
                else
                    bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                if (value == null)
                    cidade = "";
                else
                    cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                if (value == null)
                    estado = "";
                else
                    estado = value;
            }
        }

        public string Anotacoes
        {
            get
            {
                return anotacoes;
            }

            set
            {
                if (value == null)
                    anotacoes = "";
                else
                    anotacoes = value;
            }
        }
    }
}
