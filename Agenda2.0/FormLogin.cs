using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agenda2._0
{
    public partial class FormLogin : Form
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public FormLogin()
        {
            InitializeComponent();
            lblMensagem.Text = "";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UserDAO Usuario = new UserDAO();
            int resposta = Usuario.Logar(txtLogin.Text, txtSenha.Text);
			
			//verifica se a resposta do login é válida ou não
            if (resposta == -1)
                lblMensagem.Text = "Senha incorreta";
            if (resposta == 0)
                lblMensagem.Text = "Usuário não encontrado";
            if (resposta > 0)
            {
                lblMensagem.Text = "";
                id = resposta;
                this.Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
 			//fecha o form de login quando clicar o botão de cadastrar
            this.Hide();
            //abre o form de cadastro
            FormCriarConta criarConta = new FormCriarConta();
            criarConta.ShowDialog();
            //reabre o form de login quando o cadastro terminar
            this.Show();
        }
    }
}
