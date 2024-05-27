namespace ComercialSys
{
    partial class FrmClienteNovo
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
            tabControl1 = new TabControl();
            tbpDadosPessoais = new TabPage();
            btnEditar = new Button();
            btnInsert = new Button();
            lblDataNasc = new Label();
            mxtCpf = new MaskedTextBox();
            mxtTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblNome = new Label();
            chkAtivo = new CheckBox();
            dtpDataNasc = new DateTimePicker();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            tbpEnderecos = new TabPage();
            btnAdcNovo = new Button();
            btnSalvar = new Button();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            dgvEnderecos = new DataGridView();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnTipoEndereco = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tbpDadosPessoais.SuspendLayout();
            tbpEnderecos.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpDadosPessoais);
            tabControl1.Controls.Add(tbpEnderecos);
            tabControl1.Location = new Point(39, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(512, 261);
            tabControl1.TabIndex = 0;
            // 
            // tbpDadosPessoais
            // 
            tbpDadosPessoais.Controls.Add(btnEditar);
            tbpDadosPessoais.Controls.Add(btnInsert);
            tbpDadosPessoais.Controls.Add(lblDataNasc);
            tbpDadosPessoais.Controls.Add(mxtCpf);
            tbpDadosPessoais.Controls.Add(mxtTelefone);
            tbpDadosPessoais.Controls.Add(lblTelefone);
            tbpDadosPessoais.Controls.Add(lblEmail);
            tbpDadosPessoais.Controls.Add(lblCpf);
            tbpDadosPessoais.Controls.Add(lblNome);
            tbpDadosPessoais.Controls.Add(chkAtivo);
            tbpDadosPessoais.Controls.Add(dtpDataNasc);
            tbpDadosPessoais.Controls.Add(txtEmail);
            tbpDadosPessoais.Controls.Add(txtNome);
            tbpDadosPessoais.Location = new Point(4, 24);
            tbpDadosPessoais.Name = "tbpDadosPessoais";
            tbpDadosPessoais.Padding = new Padding(3);
            tbpDadosPessoais.Size = new Size(504, 233);
            tbpDadosPessoais.TabIndex = 0;
            tbpDadosPessoais.Text = "Dados pessoais";
            tbpDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(185, 198);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(28, 198);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "&Inserir";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(180, 105);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(114, 15);
            lblDataNasc.TabIndex = 14;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // mxtCpf
            // 
            mxtCpf.Location = new Point(28, 79);
            mxtCpf.Mask = "000.000.000-99";
            mxtCpf.Name = "mxtCpf";
            mxtCpf.Size = new Size(130, 23);
            mxtCpf.TabIndex = 13;
            // 
            // mxtTelefone
            // 
            mxtTelefone.Location = new Point(28, 123);
            mxtTelefone.Mask = "(99) 00000-0000";
            mxtTelefone.Name = "mxtTelefone";
            mxtTelefone.Size = new Size(130, 23);
            mxtTelefone.TabIndex = 11;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(28, 105);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 10;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(163, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(28, 61);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 8;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(28, 17);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Location = new Point(314, 24);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 6;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(185, 123);
            dtpDataNasc.MaxDate = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            dtpDataNasc.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(109, 23);
            dtpDataNasc.TabIndex = 5;
            dtpDataNasc.Value = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(163, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(28, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 23);
            txtNome.TabIndex = 1;
            // 
            // tbpEnderecos
            // 
            tbpEnderecos.Controls.Add(btnAdcNovo);
            tbpEnderecos.Controls.Add(btnSalvar);
            tbpEnderecos.Controls.Add(comboBox1);
            tbpEnderecos.Controls.Add(textBox6);
            tbpEnderecos.Controls.Add(textBox5);
            tbpEnderecos.Controls.Add(textBox4);
            tbpEnderecos.Controls.Add(textBox3);
            tbpEnderecos.Controls.Add(textBox2);
            tbpEnderecos.Controls.Add(textBox1);
            tbpEnderecos.Controls.Add(maskedTextBox1);
            tbpEnderecos.Location = new Point(4, 24);
            tbpEnderecos.Name = "tbpEnderecos";
            tbpEnderecos.Padding = new Padding(3);
            tbpEnderecos.Size = new Size(504, 233);
            tbpEnderecos.TabIndex = 1;
            tbpEnderecos.Text = "Endereços";
            tbpEnderecos.UseVisualStyleBackColor = true;
            // 
            // btnAdcNovo
            // 
            btnAdcNovo.Location = new Point(374, 194);
            btnAdcNovo.Name = "btnAdcNovo";
            btnAdcNovo.Size = new Size(161, 23);
            btnAdcNovo.TabIndex = 9;
            btnAdcNovo.Text = "Adicionar &Novo";
            btnAdcNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(22, 194);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "RES - Residencial", "COM -Comercial", "ENT - Entrega", "COB - Cobrança", "RET - Retirada", "TMP - Temporário" });
            comboBox1.Location = new Point(22, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(498, 88);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(37, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(316, 88);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(442, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(178, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 23);
            textBox1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(22, 37);
            maskedTextBox1.Mask = "00000-999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(70, 23);
            maskedTextBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvEnderecos);
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(50, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 414);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Cliente";
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.AllowUserToDeleteRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEndereco });
            dgvEnderecos.Location = new Point(39, 289);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(512, 119);
            dgvEnderecos.TabIndex = 1;
            // 
            // clnCep
            // 
            clnCep.Frozen = true;
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            clnCep.Width = 60;
            // 
            // clnLogradouro
            // 
            clnLogradouro.Frozen = true;
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 200;
            // 
            // clnNumero
            // 
            clnNumero.Frozen = true;
            clnNumero.HeaderText = "Número";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            clnNumero.Width = 60;
            // 
            // clnComplemento
            // 
            clnComplemento.Frozen = true;
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 150;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 150;
            // 
            // clnUf
            // 
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            clnUf.Width = 60;
            // 
            // clnTipoEndereco
            // 
            clnTipoEndereco.HeaderText = "Tipo";
            clnTipoEndereco.Name = "clnTipoEndereco";
            clnTipoEndereco.ReadOnly = true;
            clnTipoEndereco.Width = 60;
            // 
            // FrmClienteNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmClienteNovo";
            Text = "FrmClienteNovo";
            tabControl1.ResumeLayout(false);
            tbpDadosPessoais.ResumeLayout(false);
            tbpDadosPessoais.PerformLayout();
            tbpEnderecos.ResumeLayout(false);
            tbpEnderecos.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpDadosPessoais;
        private TabPage tbpEnderecos;
        private GroupBox groupBox1;
        private DateTimePicker dtpDataNasc;
        private TextBox txtNome;
        private TextBox txtEmail;
        private CheckBox chkAtivo;
        private MaskedTextBox mxtTelefone;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblNome;
        private MaskedTextBox mxtCpf;
        private Button btnInsert;
        private Label lblDataNasc;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnAdcNovo;
        private Button btnSalvar;
        private DataGridView dgvEnderecos;
        private Button btnEditar;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEndereco;
    }
}