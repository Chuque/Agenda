namespace Agenda2._0
{
    partial class FormAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.lblGrupos = new System.Windows.Forms.Label();
            this.lblContatos = new System.Windows.Forms.Label();
            this.pnlGrupos = new System.Windows.Forms.Panel();
            this.pnlContatos = new System.Windows.Forms.Panel();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.cbbGrupos = new System.Windows.Forms.ComboBox();
            this.txtIdPessoa = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnRmvGrupo = new System.Windows.Forms.Button();
            this.btnRmvNumero = new System.Windows.Forms.Button();
            this.btnAddGrupo = new System.Windows.Forms.Button();
            this.btnAddNumero = new System.Windows.Forms.Button();
            this.lblAnotacoes = new System.Windows.Forms.Label();
            this.lblAddGrupo = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblTelefones = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtAnotacoes = new System.Windows.Forms.TextBox();
            this.cbbGruposInseridos = new System.Windows.Forms.ComboBox();
            this.cbbTelefones = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnRmvContatos = new System.Windows.Forms.Button();
            this.btnAddContatos = new System.Windows.Forms.Button();
            this.btnRmvGrupos = new System.Windows.Forms.Button();
            this.btnAddGrupos = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.pnlGrupos.SuspendLayout();
            this.pnlContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.pnlDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToDeleteRows = false;
            this.dgvGrupos.AllowUserToResizeColumns = false;
            this.dgvGrupos.AllowUserToResizeRows = false;
            this.dgvGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.ColumnHeadersVisible = false;
            this.dgvGrupos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrupos.Location = new System.Drawing.Point(4, 3);
            this.dgvGrupos.MultiSelect = false;
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            this.dgvGrupos.RowHeadersVisible = false;
            this.dgvGrupos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupos.Size = new System.Drawing.Size(131, 280);
            this.dgvGrupos.TabIndex = 99;
            this.dgvGrupos.TabStop = false;
            this.dgvGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellClick);
            // 
            // lblGrupos
            // 
            this.lblGrupos.AutoSize = true;
            this.lblGrupos.Location = new System.Drawing.Point(13, 9);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(41, 13);
            this.lblGrupos.TabIndex = 0;
            this.lblGrupos.Text = "Grupos";
            // 
            // lblContatos
            // 
            this.lblContatos.AutoSize = true;
            this.lblContatos.Location = new System.Drawing.Point(156, 11);
            this.lblContatos.Name = "lblContatos";
            this.lblContatos.Size = new System.Drawing.Size(49, 13);
            this.lblContatos.TabIndex = 1;
            this.lblContatos.Text = "Contatos";
            // 
            // pnlGrupos
            // 
            this.pnlGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlGrupos.Controls.Add(this.dgvGrupos);
            this.pnlGrupos.Location = new System.Drawing.Point(12, 25);
            this.pnlGrupos.Name = "pnlGrupos";
            this.pnlGrupos.Size = new System.Drawing.Size(139, 286);
            this.pnlGrupos.TabIndex = 0;
            // 
            // pnlContatos
            // 
            this.pnlContatos.Controls.Add(this.dgvContatos);
            this.pnlContatos.Location = new System.Drawing.Point(156, 25);
            this.pnlContatos.Name = "pnlContatos";
            this.pnlContatos.Size = new System.Drawing.Size(200, 286);
            this.pnlContatos.TabIndex = 0;
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AllowUserToDeleteRows = false;
            this.dgvContatos.AllowUserToResizeColumns = false;
            this.dgvContatos.AllowUserToResizeRows = false;
            this.dgvContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.ColumnHeadersVisible = false;
            this.dgvContatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContatos.Location = new System.Drawing.Point(3, 3);
            this.dgvContatos.MultiSelect = false;
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.ReadOnly = true;
            this.dgvContatos.RowHeadersVisible = false;
            this.dgvContatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvContatos.Size = new System.Drawing.Size(194, 280);
            this.dgvContatos.TabIndex = 99;
            this.dgvContatos.TabStop = false;
            this.dgvContatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatos_CellClick);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtEstado);
            this.pnlDados.Controls.Add(this.txtNumero);
            this.pnlDados.Controls.Add(this.cbbGrupos);
            this.pnlDados.Controls.Add(this.txtIdPessoa);
            this.pnlDados.Controls.Add(this.lblId);
            this.pnlDados.Controls.Add(this.txtTelefone);
            this.pnlDados.Controls.Add(this.btnRmvGrupo);
            this.pnlDados.Controls.Add(this.btnRmvNumero);
            this.pnlDados.Controls.Add(this.btnAddGrupo);
            this.pnlDados.Controls.Add(this.btnAddNumero);
            this.pnlDados.Controls.Add(this.lblAnotacoes);
            this.pnlDados.Controls.Add(this.lblAddGrupo);
            this.pnlDados.Controls.Add(this.lblGrupo);
            this.pnlDados.Controls.Add(this.lblTelefones);
            this.pnlDados.Controls.Add(this.lblEstado);
            this.pnlDados.Controls.Add(this.lblCidade);
            this.pnlDados.Controls.Add(this.lblBairro);
            this.pnlDados.Controls.Add(this.lblNumero);
            this.pnlDados.Controls.Add(this.lblRua);
            this.pnlDados.Controls.Add(this.lblNome);
            this.pnlDados.Controls.Add(this.txtAnotacoes);
            this.pnlDados.Controls.Add(this.cbbGruposInseridos);
            this.pnlDados.Controls.Add(this.cbbTelefones);
            this.pnlDados.Controls.Add(this.txtCidade);
            this.pnlDados.Controls.Add(this.txtBairro);
            this.pnlDados.Controls.Add(this.txtLogradouro);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Location = new System.Drawing.Point(363, 25);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(442, 286);
            this.pnlDados.TabIndex = 2;
            this.pnlDados.Enter += new System.EventHandler(this.pnlDados_Enter);
            this.pnlDados.Leave += new System.EventHandler(this.pnlDados_Leave);
            // 
            // txtEstado
            // 
            this.txtEstado.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtEstado.Location = new System.Drawing.Point(371, 89);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PromptChar = ' ';
            this.txtEstado.Size = new System.Drawing.Size(57, 20);
            this.txtEstado.TabIndex = 5;
            this.txtEstado.Text = "Ex: SP";
            this.txtEstado.Click += new System.EventHandler(this.txtEstado_Click);
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            this.txtEstado.Enter += new System.EventHandler(this.txtEstado_Enter);
            // 
            // txtNumero
            // 
            this.txtNumero.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtNumero.Location = new System.Drawing.Point(371, 63);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PromptChar = ' ';
            this.txtNumero.Size = new System.Drawing.Size(57, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Text = "Ex: 2121";
            this.txtNumero.Click += new System.EventHandler(this.txtNumero_Click);
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.Enter += new System.EventHandler(this.txtNumero_Enter);
            // 
            // cbbGrupos
            // 
            this.cbbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGrupos.FormattingEnabled = true;
            this.cbbGrupos.Location = new System.Drawing.Point(299, 182);
            this.cbbGrupos.Name = "cbbGrupos";
            this.cbbGrupos.Size = new System.Drawing.Size(100, 21);
            this.cbbGrupos.TabIndex = 102;
            this.cbbGrupos.TabStop = false;
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.Location = new System.Drawing.Point(385, 16);
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.ReadOnly = true;
            this.txtIdPessoa.Size = new System.Drawing.Size(43, 20);
            this.txtIdPessoa.TabIndex = 101;
            this.txtIdPessoa.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(361, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 100;
            this.lblId.Text = "ID";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(233, 150);
            this.txtTelefone.Mask = "(00)000000000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PromptChar = ' ';
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Click += new System.EventHandler(this.txtTelefone_Click);
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // btnRmvGrupo
            // 
            this.btnRmvGrupo.Location = new System.Drawing.Point(182, 181);
            this.btnRmvGrupo.Name = "btnRmvGrupo";
            this.btnRmvGrupo.Size = new System.Drawing.Size(23, 23);
            this.btnRmvGrupo.TabIndex = 99;
            this.btnRmvGrupo.TabStop = false;
            this.btnRmvGrupo.Text = "-";
            this.btnRmvGrupo.UseVisualStyleBackColor = true;
            this.btnRmvGrupo.Click += new System.EventHandler(this.btnRmvGrupo_Click);
            // 
            // btnRmvNumero
            // 
            this.btnRmvNumero.Location = new System.Drawing.Point(182, 148);
            this.btnRmvNumero.Name = "btnRmvNumero";
            this.btnRmvNumero.Size = new System.Drawing.Size(23, 23);
            this.btnRmvNumero.TabIndex = 99;
            this.btnRmvNumero.TabStop = false;
            this.btnRmvNumero.Text = "-";
            this.btnRmvNumero.UseVisualStyleBackColor = true;
            this.btnRmvNumero.Click += new System.EventHandler(this.btnRmvNumero_Click);
            // 
            // btnAddGrupo
            // 
            this.btnAddGrupo.Location = new System.Drawing.Point(405, 181);
            this.btnAddGrupo.Name = "btnAddGrupo";
            this.btnAddGrupo.Size = new System.Drawing.Size(23, 23);
            this.btnAddGrupo.TabIndex = 99;
            this.btnAddGrupo.TabStop = false;
            this.btnAddGrupo.Text = "+";
            this.btnAddGrupo.UseVisualStyleBackColor = true;
            this.btnAddGrupo.Click += new System.EventHandler(this.btnAddGrupo_Click);
            // 
            // btnAddNumero
            // 
            this.btnAddNumero.Location = new System.Drawing.Point(339, 148);
            this.btnAddNumero.Name = "btnAddNumero";
            this.btnAddNumero.Size = new System.Drawing.Size(23, 23);
            this.btnAddNumero.TabIndex = 99;
            this.btnAddNumero.TabStop = false;
            this.btnAddNumero.Text = "+";
            this.btnAddNumero.UseVisualStyleBackColor = true;
            this.btnAddNumero.Click += new System.EventHandler(this.btnAddNumero_Click);
            // 
            // lblAnotacoes
            // 
            this.lblAnotacoes.AutoSize = true;
            this.lblAnotacoes.Location = new System.Drawing.Point(8, 212);
            this.lblAnotacoes.Name = "lblAnotacoes";
            this.lblAnotacoes.Size = new System.Drawing.Size(58, 13);
            this.lblAnotacoes.TabIndex = 41;
            this.lblAnotacoes.Text = "Anotações";
            // 
            // lblAddGrupo
            // 
            this.lblAddGrupo.AutoSize = true;
            this.lblAddGrupo.Location = new System.Drawing.Point(230, 185);
            this.lblAddGrupo.Name = "lblAddGrupo";
            this.lblAddGrupo.Size = new System.Drawing.Size(63, 13);
            this.lblAddGrupo.TabIndex = 39;
            this.lblAddGrupo.Text = "Add Grupos";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(25, 185);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(41, 13);
            this.lblGrupo.TabIndex = 39;
            this.lblGrupo.Text = "Grupos";
            // 
            // lblTelefones
            // 
            this.lblTelefones.AutoSize = true;
            this.lblTelefones.Location = new System.Drawing.Point(12, 153);
            this.lblTelefones.Name = "lblTelefones";
            this.lblTelefones.Size = new System.Drawing.Size(54, 13);
            this.lblTelefones.TabIndex = 39;
            this.lblTelefones.Text = "Telefones";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(325, 92);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(26, 92);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 37;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(32, 118);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 36;
            this.lblBairro.Text = "Bairro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(321, 66);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 35;
            this.lblNumero.Text = "Numero";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(5, 66);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(61, 13);
            this.lblRua.TabIndex = 34;
            this.lblRua.Text = "Logradouro";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(31, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 32;
            this.lblNome.Text = "Nome";
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.Location = new System.Drawing.Point(72, 209);
            this.txtAnotacoes.MaxLength = 300;
            this.txtAnotacoes.Multiline = true;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.Size = new System.Drawing.Size(356, 61);
            this.txtAnotacoes.TabIndex = 8;
            // 
            // cbbGruposInseridos
            // 
            this.cbbGruposInseridos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGruposInseridos.FormattingEnabled = true;
            this.cbbGruposInseridos.Location = new System.Drawing.Point(72, 182);
            this.cbbGruposInseridos.Name = "cbbGruposInseridos";
            this.cbbGruposInseridos.Size = new System.Drawing.Size(104, 21);
            this.cbbGruposInseridos.TabIndex = 99;
            this.cbbGruposInseridos.TabStop = false;
            // 
            // cbbTelefones
            // 
            this.cbbTelefones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTelefones.FormattingEnabled = true;
            this.cbbTelefones.Location = new System.Drawing.Point(72, 150);
            this.cbbTelefones.Name = "cbbTelefones";
            this.cbbTelefones.Size = new System.Drawing.Size(104, 21);
            this.cbbTelefones.TabIndex = 99;
            this.cbbTelefones.TabStop = false;
            // 
            // txtCidade
            // 
            this.txtCidade.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtCidade.Location = new System.Drawing.Point(72, 89);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(243, 20);
            this.txtCidade.TabIndex = 4;
            this.txtCidade.Text = "Ex: São Carlos";
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            // 
            // txtBairro
            // 
            this.txtBairro.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtBairro.Location = new System.Drawing.Point(72, 115);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(155, 20);
            this.txtBairro.TabIndex = 6;
            this.txtBairro.Text = "Ex: Centro";
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtLogradouro.Location = new System.Drawing.Point(72, 63);
            this.txtLogradouro.MaxLength = 40;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(243, 20);
            this.txtLogradouro.TabIndex = 2;
            this.txtLogradouro.Text = "Ex: Av. São Carlos";
            this.txtLogradouro.Enter += new System.EventHandler(this.txtRua_Enter);
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtNome.Location = new System.Drawing.Point(72, 16);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Ex: João Batista";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            // 
            // btnRmvContatos
            // 
            this.btnRmvContatos.Location = new System.Drawing.Point(330, 317);
            this.btnRmvContatos.Name = "btnRmvContatos";
            this.btnRmvContatos.Size = new System.Drawing.Size(23, 23);
            this.btnRmvContatos.TabIndex = 99;
            this.btnRmvContatos.TabStop = false;
            this.btnRmvContatos.Text = "-";
            this.btnRmvContatos.UseVisualStyleBackColor = true;
            this.btnRmvContatos.Click += new System.EventHandler(this.btnRmvContatos_Click);
            // 
            // btnAddContatos
            // 
            this.btnAddContatos.Location = new System.Drawing.Point(301, 317);
            this.btnAddContatos.Name = "btnAddContatos";
            this.btnAddContatos.Size = new System.Drawing.Size(23, 23);
            this.btnAddContatos.TabIndex = 99;
            this.btnAddContatos.TabStop = false;
            this.btnAddContatos.Text = "+";
            this.btnAddContatos.UseVisualStyleBackColor = true;
            this.btnAddContatos.Click += new System.EventHandler(this.btnAddContatos_Click);
            // 
            // btnRmvGrupos
            // 
            this.btnRmvGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRmvGrupos.Location = new System.Drawing.Point(124, 317);
            this.btnRmvGrupos.Name = "btnRmvGrupos";
            this.btnRmvGrupos.Size = new System.Drawing.Size(23, 23);
            this.btnRmvGrupos.TabIndex = 99;
            this.btnRmvGrupos.TabStop = false;
            this.btnRmvGrupos.Text = "-";
            this.btnRmvGrupos.UseVisualStyleBackColor = true;
            this.btnRmvGrupos.Click += new System.EventHandler(this.btnRmvGrupos_Click);
            // 
            // btnAddGrupos
            // 
            this.btnAddGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddGrupos.Location = new System.Drawing.Point(95, 317);
            this.btnAddGrupos.Name = "btnAddGrupos";
            this.btnAddGrupos.Size = new System.Drawing.Size(23, 23);
            this.btnAddGrupos.TabIndex = 99;
            this.btnAddGrupos.TabStop = false;
            this.btnAddGrupos.Text = "+";
            this.btnAddGrupos.UseVisualStyleBackColor = true;
            this.btnAddGrupos.Click += new System.EventHandler(this.btnAddGrupos_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(725, 317);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPesquisa.Location = new System.Drawing.Point(211, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(142, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeGrupo.Location = new System.Drawing.Point(16, 318);
            this.txtNomeGrupo.MaxLength = 30;
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(73, 20);
            this.txtNomeGrupo.TabIndex = 10;
            this.txtNomeGrupo.Enter += new System.EventHandler(this.txtNomeGrupo_Enter);
            this.txtNomeGrupo.Leave += new System.EventHandler(this.txtNomeGrupo_Leave);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 349);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRmvGrupos);
            this.Controls.Add(this.btnAddGrupos);
            this.Controls.Add(this.btnRmvContatos);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.lblContatos);
            this.Controls.Add(this.btnAddContatos);
            this.Controls.Add(this.lblGrupos);
            this.Controls.Add(this.pnlContatos);
            this.Controls.Add(this.pnlGrupos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.pnlGrupos.ResumeLayout(false);
            this.pnlContatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.Label lblContatos;
        private System.Windows.Forms.Panel pnlGrupos;
        private System.Windows.Forms.Panel pnlContatos;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Button btnAddContatos;
        private System.Windows.Forms.Button btnRmvContatos;
        private System.Windows.Forms.Button btnRmvGrupos;
        private System.Windows.Forms.Button btnAddGrupos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblAnotacoes;
        private System.Windows.Forms.Label lblTelefones;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtAnotacoes;
        private System.Windows.Forms.ComboBox cbbTelefones;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnRmvNumero;
        private System.Windows.Forms.Button btnAddNumero;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtIdPessoa;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbbGrupos;
        private System.Windows.Forms.Button btnRmvGrupo;
        private System.Windows.Forms.Button btnAddGrupo;
        private System.Windows.Forms.Label lblAddGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cbbGruposInseridos;
        private System.Windows.Forms.MaskedTextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.DataGridView dgvContatos;
    }
}

