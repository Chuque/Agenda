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
/*classe para o form de criar conta*/    
    public partial class FormCriarConta : Form
    {
        public FormCriarConta()
        {
            InitializeComponent();
            lblMensagem.Text = "";
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
        	//verifica se os campos de cadastro estão vazios
            if (txtLogin.Text == "" || txtSenha.Text == "" || txtConfirmarSenha.Text == "")
            {
            //seta os campos como vazios por padrão
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtConfirmarSenha.Text = "";
                txtLogin.Focus();
                lblMensagem.Text = "Todos os campos são obrigatórios";
                return;
            }
            
            else if (txtLogin.Text.Length < 4)
            {
                lblMensagem.Text = "O usuário precisa ter pelo menos 4 caracteres";
                txtLogin.Focus();
                return;
            }
            else if (txtSenha.Text.Length < 4)
            {
                lblMensagem.Text = "A senha precisa ter pelo menos 4 caracteres";
                txtSenha.Focus();
                return;
            }
            //confere se os campos de senhas batem
            else if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                lblMensagem.Text = "Senhas não conferem";
                txtSenha.Text = "";
                txtConfirmarSenha.Text = "";
                txtSenha.Focus();
                return;
            }
            else
            {
                UserDAO Usuario = new UserDAO();
               	//cria devidamente o cadastro do usuário no banco
                if (Usuario.AddUser(txtLogin.Text, txtSenha.Text))
                {
                    lblMensagem.Text = "";                    
                    MessageBox.Show("Conta criada com sucesso!");
                    this.Close();
                }
               	//se não o usuário já existe
                else
                {
                    lblMensagem.Text = "Usuário já existe!";
                }
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
