using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda2._0
{
    public partial class FormRelatorioContatos : Form
    {
        private int idUsuario;

        public FormRelatorioContatos(int idUsuario)
        {
            InitializeComponent();
            
            this.idUsuario = idUsuario;
        }

        private void FormRelatorioContatos_Load(object sender, EventArgs e)
        {
            ContatoDAO contatoDao = new ContatoDAO();
            List<Contato> lista = contatoDao.ListAll(0, idUsuario);

            CrvContatos report = new CrvContatos();
            report.SetDataSource(lista);
            crvRelatorioContatos.ReportSource = report;
        }
    }
}
