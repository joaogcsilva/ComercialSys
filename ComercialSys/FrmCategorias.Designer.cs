namespace ComercialSys
{
    partial class FrmCategorias
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
            label9 = new Label();
            txtID = new TextBox();
            label8 = new Label();
            txtSigla = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            btnInserir = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            groupBox1 = new GroupBox();
            btnDeletar = new Button();
            txtBusca = new TextBox();
            dgvCategorias = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            Sigla = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(61, 105);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 5;
            label9.Text = "Nome";
            // 
            // txtID
            // 
            txtID.Location = new Point(107, 70);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(71, 23);
            txtID.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 136);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 6;
            label8.Text = "Sigla";
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 73);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 0;
            label4.Text = "ID";
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
            btnEditar.Location = new Point(213, 190);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(66, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(141, 190);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(66, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeletar);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtSigla);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(30, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 232);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de Categorias";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(285, 190);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(66, 22);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "&Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(30, 250);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite pelo menos duas letras para pesquisar categoria";
            txtBusca.Size = new Size(516, 23);
            txtBusca.TabIndex = 12;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { clnid, clnNome, Sigla });
            dgvCategorias.Location = new Point(30, 279);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.Size = new Size(516, 228);
            dgvCategorias.TabIndex = 13;
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
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(txtBusca);
            Controls.Add(dgvCategorias);
            Controls.Add(groupBox1);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txtID;
        private Label label8;
        private TextBox txtSigla;
        private TextBox txtNome;
        private Label label4;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnConsultar;
        private GroupBox groupBox1;
        private TextBox txtBusca;
        private DataGridView dgvCategorias;
        private Button btnDeletar;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn Sigla;
    }
}