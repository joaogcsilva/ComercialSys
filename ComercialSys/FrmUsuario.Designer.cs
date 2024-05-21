namespace ComercialSys
{
    partial class FrmUsuario
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
            label1 = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtConfSenha = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cmbNivel = new ComboBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            dgvUsuarios = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            txtBusca = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 33);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(111, 119);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(111, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(300, 23);
            txtNome.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(111, 30);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(71, 23);
            txtID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 62);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 91);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 122);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 149);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 8;
            label5.Text = "Confirma Senha";
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(111, 146);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(100, 23);
            txtConfSenha.TabIndex = 3;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbNivel);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtConfSenha);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(77, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de Usuário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 146);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 14;
            label6.Text = "Nível";
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(298, 141);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(113, 23);
            cmbNivel.TabIndex = 4;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(267, 189);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(106, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(152, 189);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(41, 189);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnid, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(77, 351);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 11;
            // 
            // clnid
            // 
            clnid.Frozen = true;
            clnid.HeaderText = "ID";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            clnid.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 180;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nível";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 60;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 40;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(77, 322);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite pelo menos duas letras para pesquisar usuário";
            txtBusca.Size = new Size(500, 23);
            txtBusca.TabIndex = 1;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(txtBusca);
            Controls.Add(dgvUsuarios);
            Controls.Add(groupBox1);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtConfSenha;
        private GroupBox groupBox1;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnInserir;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
        private TextBox txtBusca;
        private Label label6;
        private ComboBox cmbNivel;
    }
}