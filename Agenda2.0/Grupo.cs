using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda2._0
{

/*classe para o objeto Grupo*/

    class Grupo
    {
        private int idUsuario;
        private int idGrupo;
        private string nomeGrupo;

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

        public int IdGrupo
        {
            get
            {
                return idGrupo;
            }

            set
            {
                idGrupo = value;
            }
        }

        public string NomeGrupo
        {
            get
            {
                return nomeGrupo;
            }

            set
            {
                nomeGrupo = value;
            }
        }
    }
}
