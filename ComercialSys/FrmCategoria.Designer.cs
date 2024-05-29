namespace ComercialSys
{
    partial class FrmCategoria
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
            label2 = new Label();
            txtId = new TextBox();
            label4 = new Label();
            txtSigla = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            btnInserir = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            groupBox1 = new GroupBox();
            txtBusca = new TextBox();
            dgvUsuarios = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            Sigla = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 105);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 70);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 136);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Sigla";
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(107, 133);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(65, 23);
            txtSigla.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(107, 102);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(179, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 73);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(69, 190);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(66, 22);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(293, 189);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(66, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(180, 189);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(66, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtSigla);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(30, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 232);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de Categorias";
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(30, 250);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite pelo menos duas letras para pesquisar categorias";
            txtBusca.Size = new Size(516, 23);
            txtBusca.TabIndex = 12;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnid, clnNome, Sigla });
            dgvUsuarios.Location = new Point(30, 279);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(516, 228);
            dgvUsuarios.TabIndex = 13;
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
            clnNome.Width = 250;
            // 
            // Sigla
            // 
            Sigla.HeaderText = "Sigla";
            Sigla.Name = "Sigla";
            Sigla.ReadOnly = true;
            Sigla.Width = 250;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(txtBusca);
            Controls.Add(dgvUsuarios);
            Controls.Add(groupBox1);
            Name = "FrmCategoria";
            Text = "FrmCategorias";
            Load += FrmCategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtId;
        private Label label4;
        private TextBox txtSigla;
        private TextBox txtNome;
        private Label label1;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnConsultar;
        private GroupBox groupBox1;
        private TextBox txtBusca;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn Sigla;
    }
}