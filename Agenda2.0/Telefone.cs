using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda2._0
{

/*classe para o objeto Telefone*/

    class Telefone
    {
        private string nroTelefone;
        private int idContato;

        public string NroTelefone
        {
            get
            {
                return nroTelefone;
            }

            set
            {
                nroTelefone = value;
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
    }
}
