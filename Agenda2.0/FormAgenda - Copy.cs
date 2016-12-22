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
    public partial class FormAgenda : Form
    {
		//instancia objeto banco
        private Banco banco = new Banco();

		//cria variável que guarda idUser
        private int idUser;

        public int Id
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public FormAgenda()
        {
            InitializeComponent();
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            //criando as colunas da tabela de grupos
            dgvGrupos.Columns.Add("idGrupo", "idGrupo");
            dgvGrupos.Columns[0].Visible = false;
            dgvGrupos.Columns.Add("nomeGrupo", "nomeGrupo");//cria a coluna nomeGrupo na dgv
            dgvGrupos.Rows.Add(0, "Todos");//adiciona a linha Todos para exibir todos os contatos ao ser clicada            

            //criando as colunas da tabela de contatos
            dgvContatos.Columns.Add("idPessoa", "idPessoa");
            dgvContatos.Columns[0].Visible = false;
            dgvContatos.Columns.Add("nomePessoa", "nomePessoa");

			//cria DAO do grupo
            GrupoDAO grupo = new GrupoDAO();
            List<Grupo> grupos = new List<Grupo>();
            grupos = grupo.ListAllFromUser(idUser);

            //se houver pelo menos 1 item na lista de grupos
            if(grupos.Count>0)
            {
                //percorre elementos em grupos
                foreach (Grupo g in grupos)
                {
                    dgvGrupos.Rows.Add(g.IdGrupo, g.NomeGrupo);//adiciona os grupos à dgvgrupos...
                    cbbGrupos.Items.Add(g.NomeGrupo);//e à cbb grupos
                }
                cbbGrupos.SelectedItem = cbbGrupos.Items[0];//seleciona automaticamente o primeiro grupo da combobox
            }

            dgvGrupos_CellClick(null, null);
        }

        private void SetCoresPreto()
        {
            txtNome.ForeColor = System.Drawing.Color.Black;
            txtLogradouro.ForeColor = System.Drawing.Color.Black;
            txtNumero.ForeColor = System.Drawing.Color.Black;
            txtCidade.ForeColor = System.Drawing.Color.Black;
            txtEstado.ForeColor = System.Drawing.Color.Black;
            txtBairro.ForeColor = System.Drawing.Color.Black;
        }

        //essa função altera as cores para cinza e adiciona os textos de exemplo
        private void SetCoresCinza()
        {
            txtNome.ForeColor = System.Drawing.Color.LightSteelBlue;
            txtLogradouro.ForeColor = System.Drawing.Color.LightSteelBlue;
            txtNumero.ForeColor = System.Drawing.Color.LightSteelBlue;
            txtCidade.ForeColor = System.Drawing.Color.LightSteelBlue;
            txtEstado.ForeColor = System.Drawing.Color.LightSteelBlue;
            txtBairro.ForeColor = System.Drawing.Color.LightSteelBlue;

            txtNome.Text = "Ex: João Batista";
            txtLogradouro.Text = "Ex: Av. São Carlos";
            txtNumero.Mask = "";
            txtNumero.Text = "Ex: 2121";
            txtCidade.Text = "Ex: São Carlos";
            txtEstado.Mask = "";
            txtEstado.Text = "Ex: SP";
            txtBairro.Text = "Ex: Centro";
            txtTelefone.Text = "";
            txtAnotacoes.Text = "";
            cbbTelefones.Items.Clear();
        }

		//altera a cor da TextBox Nome
        private void txtNome_Enter(object sender, EventArgs e)
        {
            if(txtNome.ForeColor!=System.Drawing.Color.Black)
            {
                txtNome.ForeColor = System.Drawing.Color.Black;
                txtNome.SelectionStart = 0;
                txtNome.SelectionLength = txtNome.Text.Length;
            }

        }

		//altera a cor da TextBox Rua
        private void txtRua_Enter(object sender, EventArgs e)
        {
            if (txtLogradouro.ForeColor != System.Drawing.Color.Black)
            {
                txtLogradouro.ForeColor = System.Drawing.Color.Black;
                txtLogradouro.SelectionStart = 0;
                txtLogradouro.SelectionLength = txtLogradouro.Text.Length;
            }
        }

		//altera a cor da TextBox Numero
        private void txtNumero_Enter(object sender, EventArgs e)
        {
            if (txtNumero.ForeColor != System.Drawing.Color.Black)
            {
                txtNumero.ForeColor = System.Drawing.Color.Black;
                //txtNumero.Text = "";
                //txtNumero.Mask = "00000";
                txtNumero.SelectionStart = 0;
                txtNumero.SelectionLength = 0;
            }
        }

		//altera a cor da TextBox Cidade
        private void txtCidade_Enter(object sender, EventArgs e)
        {
            if (txtCidade.ForeColor != System.Drawing.Color.Black)
            {
                txtCidade.ForeColor = System.Drawing.Color.Black;
                txtCidade.SelectionStart = 0;
                txtCidade.SelectionLength = txtCidade.Text.Length;
            }
        }

		//altera a cor da TextBox Estado
        private void txtEstado_Enter(object sender, EventArgs e)
        {
            if (txtEstado.ForeColor != System.Drawing.Color.Black)
            {
                txtEstado.ForeColor = System.Drawing.Color.Black;
                txtEstado.SelectionStart = 0;
                txtEstado.SelectionLength = txtEstado.Text.Length;
                //txtEstado.Mask = ">LL";
                //txtEstado.Text = "";
            }
        }

		//altera a cor da TextBox Bairro
        private void txtBairro_Enter(object sender, EventArgs e)
        {
            if (txtBairro.ForeColor != System.Drawing.Color.Black)
            {
                txtBairro.ForeColor = System.Drawing.Color.Black;
                txtBairro.SelectionStart = 0;
                txtBairro.SelectionLength = txtBairro.Text.Length;
            }
        }

        private void btnAddContatos_Click(object sender, EventArgs e)
        {
            //instancia DAO pra pessoa
            ContatoDAO pessoaDao = new ContatoDAO();
            txtIdPessoa.Text = pessoaDao.GetNextId().ToString();

            SetCoresCinza();

            dgvContatos.ClearSelection();
            txtNome.Focus();
            
            btnSalvar.Text = "Adicionar";
        }

        

        private void dgvGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //preenchendo a tabela de contatos
            dgvContatos.Rows.Clear();//limpa as linhas da datagridview para poder atualizar com os novos valores
			
			//instancia DAO pessoa
            ContatoDAO pessoaDao = new ContatoDAO();

            List<Contato> pessoas = pessoaDao.ListAll(int.Parse(dgvGrupos.Rows[dgvGrupos.CurrentRow.Index].Cells[0].Value.ToString()), idUser);
            
            //percorre elementos da lista de pessoas
            foreach (Contato pessoa in pessoas)
            {
                dgvContatos.Rows.Add(pessoa.IdContato, pessoa.NomeContato);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            int idGrupo = int.Parse(dgvGrupos.Rows[dgvGrupos.CurrentRow.Index].Cells[0].Value.ToString());
            string nome = txtPesquisa.Text;

            ContatoDAO pessoaDao = new ContatoDAO();
            List<Contato> pessoas;

            if (nome == null)
                pessoas = pessoaDao.ListAll(idGrupo, idUser);

            else
                pessoas = pessoaDao.ListByName(nome, idGrupo, idUser);

            dgvContatos.Rows.Clear();

            foreach (Contato pessoa in pessoas)
            {
                dgvContatos.Rows.Add(pessoa.IdContato, pessoa.NomeContato);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Telefone telefone;
            List<Telefone> telefones = new List<Telefone>();
            
            if (cbbTelefones.Items.Count > 0)
                for(int i=0;i<cbbTelefones.Items.Count;i++)
                {
                    telefone = new Telefone();
                    telefone.IdContato = int.Parse(txtIdPessoa.Text);
                    telefone.NroTelefone = cbbTelefones.Items[i].ToString();
                    
                    telefones.Add(telefone);
                }

            ContatoDAO contatoDao = new ContatoDAO();
            PertenceDAO pertenceDao = new PertenceDAO();

            List<string> nomeGrupos = new List<string>();

            for(int i=0;i<cbbGruposInseridos.Items.Count;i++)
            {
                //adiciona os nomes dos grupos da cbb gruposinseridos numa lista
                nomeGrupos.Add(cbbGruposInseridos.Items[i].ToString());
            }

            //envia essa lista para a função IdGrupos que retorna uma lista de inteiros com os respectivos ids dos grupos
            List<int> idGrupos = pertenceDao.IdGrupos(nomeGrupos, idUser);

            Contato pessoa = new Contato();
            pessoa.IdUsuario = idUser;
            pessoa.IdContato = int.Parse(txtIdPessoa.Text);
            pessoa.NomeContato = txtNome.Text;
            pessoa.Logradouro = txtLogradouro.Text;
            pessoa.Numero = int.Parse(txtNumero.Text);
            pessoa.Bairro = txtBairro.Text;
            pessoa.Cidade = txtCidade.Text;
            pessoa.Estado = txtEstado.Text;
            pessoa.Anotacoes = txtAnotacoes.Text;

            if (btnSalvar.Text == "Adicionar")
            {
                //adiciona a pessoa, seus telefones, e adiciona essa pessoa a seus grupos
                contatoDao.AddContato(pessoa, telefones, idGrupos);
                
                dgvGrupos_CellClick(null, null);
            }
            else
            {
                contatoDao.AtualizarContato(pessoa, telefones, idGrupos);

                dgvGrupos_CellClick(null, null);
            }
        }

        //adiciona números de telefones na combobox
        private void btnAddNumero_Click(object sender, EventArgs e)
        {
            if(txtTelefone.Text != "")
                for (int i = 0; i < cbbTelefones.Items.Count; i++)
                    if (String.Compare(cbbTelefones.Items[i].ToString(), txtTelefone.Text.ToString()) == 0)
                    {
                        txtTelefone.Text = "";
                        return;
                    }
            cbbTelefones.Items.Add(txtTelefone.Text);
            cbbTelefones.SelectedItem = cbbTelefones.Items[cbbTelefones.Items.Count-1];//cbbTelefones.Items.Count - 1;
            txtTelefone.Text = "";
        }

        private void dgvContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ContatoDAO contatos = new ContatoDAO();

            List<Contato> pessoas = new List<Contato>();
            pessoas = contatos.ListAll(int.Parse(dgvGrupos.Rows[dgvGrupos.CurrentRow.Index].Cells[0].Value.ToString()), idUser);
            
            if (dgvContatos.Rows.Count > 0)
            {

                SetCoresPreto();

                //mostra os respesctivos dados nos respectivos campos ao clicar em um contato
                txtIdPessoa.Text = pessoas[dgvContatos.CurrentRow.Index].IdContato.ToString();
                txtNome.Text = pessoas[dgvContatos.CurrentRow.Index].NomeContato;
                txtLogradouro.Text = pessoas[dgvContatos.CurrentRow.Index].Logradouro;
                txtCidade.Text = pessoas[dgvContatos.CurrentRow.Index].Cidade;
                txtEstado.Text = pessoas[dgvContatos.CurrentRow.Index].Estado;
                txtNumero.Text = pessoas[dgvContatos.CurrentRow.Index].Numero.ToString();
                txtBairro.Text = pessoas[dgvContatos.CurrentRow.Index].Bairro;
                txtAnotacoes.Text = pessoas[dgvContatos.CurrentRow.Index].Anotacoes;

                TelefoneDAO telefoneDao = new TelefoneDAO();

                List<Telefone> telefones = telefoneDao.ListAll(int.Parse(txtIdPessoa.Text));

                cbbTelefones.Items.Clear();

				//percorre a lista de telefones
                foreach(Telefone telefone in telefones)
                {
                    //adiciona os numeros da pessoa na combobox de telefones
                    cbbTelefones.Items.Add(telefone.NroTelefone.ToString());
                }

                //seleciona o primeiro numero de telefone por padrão
                if (cbbTelefones.Items.Count > 0)
                    cbbTelefones.SelectedItem = cbbTelefones.Items[0];
                 
            if (dgvContatos.Rows.Count > 0)
            {
                //dgvContatos_CellClick(null, null);

                PertenceDAO pertenceDao = new PertenceDAO();

                List<int> grupos = pertenceDao.ListGruposInseridos(int.Parse(txtIdPessoa.Text));

                cbbGruposInseridos.Items.Clear();
                
                if (grupos.Count > 0)
                {
                    foreach (int idGrupo in grupos)
                        for (int i = 0; i < dgvGrupos.RowCount; i++)
                            if (int.Parse(dgvGrupos.Rows[i].Cells[0].Value.ToString()) == idGrupo)
                                cbbGruposInseridos.Items.Add(dgvGrupos.Rows[i].Cells[1].Value.ToString());

                    cbbGruposInseridos.SelectedItem = cbbGruposInseridos.Items[0];
                }
            }
                
            else
            {
                btnAddContatos_Click(null, null);
                txtNome.Focus();
            }
            }
            else
            {
                btnAddContatos_Click(null, null);
                txtNome.Focus();
            }

            btnSalvar.Text = "Salvar";
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            //se não houver texto ao entrar na textbox, o cursor é movido para o começo da caixa
            if (txtTelefone.Text == "")
            {
                txtTelefone.SelectionStart = 0;
                txtTelefone.SelectionLength = txtNome.Text.Length;
            }
            this.AcceptButton = btnAddNumero;
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            pnlDados_Enter(null, null);
            btnAddNumero_Click(null, null);
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            //ao clicar na caixa de texto chama-se o metodo txtTelefone_Enter
            txtTelefone_Enter(sender, e);
        }
        
        private void btnRmvNumero_Click(object sender, EventArgs e)
        {
        	//remove o numero selecionado caso haja pelo menos 1
            if(cbbTelefones.Items.Count>0)
                cbbTelefones.Items.Remove(cbbTelefones.SelectedItem);

            if (cbbTelefones.Items.Count > 0)
                cbbTelefones.SelectedIndex = 0;
        }

        private void btnRmvContatos_Click(object sender, EventArgs e)
        {
            ContatoDAO pessoaDao = new ContatoDAO();

            pessoaDao.RemoverContato(int.Parse(txtIdPessoa.Text));

            dgvGrupos_CellClick(null, null);
        }

        private void txtNumero_Click(object sender, EventArgs e)
        {
            txtNumero_Enter(null, null);
        }

        private void txtEstado_Click(object sender, EventArgs e)
        {
            txtEstado_Enter(null, null);
        }
        
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.Mask = "00000";
        }
        
        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            txtEstado.Mask = ">LL";
        }

        private void btnAddGrupos_Click(object sender, EventArgs e)
        {
            GrupoDAO grupoDao = new GrupoDAO();
            int id = grupoDao.NextId();
            
            if(txtNomeGrupo.Text != "")
            {
				//adiciona um novo grupo com o devido nome
                grupoDao.AddGrupo(idUser, id, txtNomeGrupo.Text);
                dgvGrupos.Rows.Add(id, txtNomeGrupo.Text);

                txtNomeGrupo.Text = "";
            }
            
        }

        private void btnRmvGrupos_Click(object sender, EventArgs e)
        {
            int idGrupo = int.Parse(dgvGrupos.Rows[dgvGrupos.CurrentRow.Index].Cells[0].Value.ToString());

            GrupoDAO grupoDao = new GrupoDAO();
			//remove grupo com o devido id no banco e na devida linha da datagrid
            grupoDao.DeleteGrupo(idGrupo);
            dgvGrupos.Rows.Remove(dgvGrupos.CurrentRow);

            dgvGrupos_CellClick(null, null);
        }

        //ao entrar na textbox o acceptbutton se torna o botao add grupos
        private void txtNomeGrupo_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnAddGrupos;
        }
        
        //ao sair da textbox o acceptbutton se torna nulo
        private void txtNomeGrupo_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void pnlDados_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSalvar;
        }

        private void pnlDados_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnAddGrupo_Click(object sender, EventArgs e)
        {
            for(int i=0;i< cbbGruposInseridos.Items.Count;i++)
            {
                if (String.Compare(cbbGruposInseridos.Items[i].ToString(), cbbGrupos.Items[cbbGrupos.SelectedIndex].ToString()) == 0)
                    return;
            }
            cbbGruposInseridos.Items.Add(cbbGrupos.Items[cbbGrupos.SelectedIndex].ToString());
            cbbGruposInseridos.SelectedItem = cbbGruposInseridos.Items[cbbGruposInseridos.Items.Count - 1];
        }

        private void btnRmvGrupo_Click(object sender, EventArgs e)
        {
            if (cbbGruposInseridos.Items.Count > 0)
            {
                cbbGruposInseridos.Items.Remove(cbbGruposInseridos.SelectedItem);
                cbbGruposInseridos.SelectedItem = cbbGruposInseridos.Items[0];
            }
                

        }
    }
}
