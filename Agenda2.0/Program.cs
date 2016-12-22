using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda2._0
{
    static class Program
    {
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin login = new FormLogin();            
            login.ShowDialog();

            if (login.Id>0)
            {                
                FormAgenda agenda = new FormAgenda();
                agenda.Id = login.Id;
                Application.Run(agenda);                
            }
                
        }
    }
}
