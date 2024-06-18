namespace ComercialSys
{
    partial class FrmProduto
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
            txtDescricao = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBarras = new TextBox();
            label3 = new Label();
            txtCategoria = new TextBox();
            txtUniVendas = new TextBox();
            txtEstoqueMin = new TextBox();
            txtClasseDesc = new TextBox();
            txtImagem = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnInserir = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            label9 = new Label();
            txtID = new TextBox();
            label10 = new Label();
            txtBusca = new TextBox();
            dgvUsuarios = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoque = new DataGridViewTextBoxColumn();
            clnUnidade = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(158, 84);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(336, 23);
            txtDescricao.TabIndex = 1;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(626, 84);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(79, 23);
            txtValorUnit.TabIndex = 2;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(158, 142);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(189, 23);
            txtCodBarras.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 145);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Código de Barras";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(158, 113);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(189, 23);
            txtCategoria.TabIndex = 6;
            // 
            // txtUniVendas
            // 
            txtUniVendas.Location = new Point(626, 113);
            txtUniVendas.Name = "txtUniVendas";
            txtUniVendas.Size = new Size(79, 23);
            txtUniVendas.TabIndex = 7;
            // 
            // txtEstoqueMin
            // 
            txtEstoqueMin.Location = new Point(626, 171);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.Size = new Size(79, 23);
            txtEstoqueMin.TabIndex = 8;
            // 
            // txtClasseDesc
            // 
            txtClasseDesc.Location = new Point(626, 142);
            txtClasseDesc.Name = "txtClasseDesc";
            txtClasseDesc.Size = new Size(79, 23);
            txtClasseDesc.TabIndex = 10;
            // 
            // txtImagem
            // 
            txtImagem.Location = new Point(263, 200);
            txtImagem.Name = "txtImagem";
            txtImagem.Size = new Size(215, 23);
            txtImagem.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 87);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 12;
            label1.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 87);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 13;
            label4.Text = "Valor Unitario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 116);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 14;
            label5.Text = "Unidade de Venda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 116);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 15;
            label2.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(563, 145);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 16;
            label6.Text = "Desconto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(526, 174);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 17;
            label7.Text = "Estoque Mínimo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 203);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 18;
            label8.Text = "Imagem";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(198, 249);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 19;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(314, 249);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(431, 249);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 21;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 216);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 23;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(308, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(51, 23);
            txtID.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(284, 33);
            label10.Name = "label10";
            label10.Size = new Size(18, 15);
            label10.TabIndex = 25;
            label10.Text = "ID";
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 315);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite pelo menos duas letras para pesquisar produto";
            txtBusca.Size = new Size(768, 23);
            txtBusca.TabIndex = 27;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnid, clnCodigo, clnCategoria, clnEstoque, clnUnidade, clnValor, clnDesconto, clnDescricao });
            dgvUsuarios.Location = new Point(12, 344);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(768, 179);
            dgvUsuarios.TabIndex = 28;
            // 
            // clnid
            // 
            clnid.Frozen = true;
            clnid.HeaderText = "ID";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            // 
            // clnCodigo
            // 
            clnCodigo.Frozen = true;
            clnCodigo.HeaderText = "Codigo";
            clnCodigo.Name = "clnCodigo";
            clnCodigo.ReadOnly = true;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoque
            // 
            clnEstoque.Frozen = true;
            clnEstoque.HeaderText = "Estoque";
            clnEstoque.Name = "clnEstoque";
            clnEstoque.ReadOnly = true;
            // 
            // clnUnidade
            // 
            clnUnidade.Frozen = true;
            clnUnidade.HeaderText = "Unidade";
            clnUnidade.Name = "clnUnidade";
            clnUnidade.ReadOnly = true;
            // 
            // clnValor
            // 
            clnValor.Frozen = true;
            clnValor.HeaderText = "Valor";
            clnValor.Name = "clnValor";
            clnValor.ReadOnly = true;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtBusca);
            Controls.Add(label10);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnInserir);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtImagem);
            Controls.Add(txtClasseDesc);
            Controls.Add(txtEstoqueMin);
            Controls.Add(txtUniVendas);
            Controls.Add(txtCategoria);
            Controls.Add(label3);
            Controls.Add(txtCodBarras);
            Controls.Add(txtValorUnit);
            Controls.Add(txtDescricao);
            Name = "FrmProduto";
            Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDescricao;
        private TextBox txtValorUnit;
        private TextBox txtCategoria;
        private Label label3;
        private TextBox txtCodBarras;
        private TextBox txtUniVendas;
        private TextBox txtEstoqueMin;
        private TextBox txtClasseDesc;
        private TextBox txtImagem;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnConsultar;
        private Label label9;
        private TextBox txtID;
        private Label label10;
        private TextBox txtBusca;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoque;
        private DataGridViewTextBoxColumn clnUnidade;
        private DataGridViewTextBoxColumn clnValor;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDescricao;
    }
}