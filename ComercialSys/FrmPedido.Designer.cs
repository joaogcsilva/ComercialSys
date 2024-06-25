namespace ComercialSys
{
    partial class FrmPedido
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNumeroPedido = new TextBox();
            label3 = new Label();
            txtVendedor = new TextBox();
            btnAbrirNovo = new Button();
            gbxProduto = new GroupBox();
            lblDescMax = new Label();
            label8 = new Label();
            txtDescontoItem = new TextBox();
            btnInserirItem = new Button();
            label7 = new Label();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label6 = new Label();
            txtDescricao = new TextBox();
            txtCodBar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dgvItens = new DataGridView();
            btn = new Button();
            txtOutros = new TextBox();
            txtDesconto = new TextBox();
            txtTotal = new TextBox();
            txtSubTotal = new TextBox();
            label9 = new Label();
            btnExcluirItem = new Button();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnValorItem = new DataGridViewTextBoxColumn();
            clnId = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(35, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 34);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(380, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(947, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 21);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Pedido";
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroPedido.ForeColor = Color.Red;
            txtNumeroPedido.Location = new Point(1004, 21);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.RightToLeft = RightToLeft.Yes;
            txtNumeroPedido.Size = new Size(141, 50);
            txtNumeroPedido.TabIndex = 3;
            txtNumeroPedido.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 72);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(98, 69);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(306, 23);
            txtVendedor.TabIndex = 5;
            // 
            // btnAbrirNovo
            // 
            btnAbrirNovo.Location = new Point(613, 172);
            btnAbrirNovo.Name = "btnAbrirNovo";
            btnAbrirNovo.Size = new Size(118, 49);
            btnAbrirNovo.TabIndex = 6;
            btnAbrirNovo.Text = "&Abrir Pedido";
            btnAbrirNovo.UseVisualStyleBackColor = true;
            btnAbrirNovo.Click += btnAbrirNovo_Click;
            // 
            // gbxProduto
            // 
            gbxProduto.Controls.Add(lblDescMax);
            gbxProduto.Controls.Add(label8);
            gbxProduto.Controls.Add(txtDescontoItem);
            gbxProduto.Controls.Add(btnInserirItem);
            gbxProduto.Controls.Add(label7);
            gbxProduto.Controls.Add(txtQuantidade);
            gbxProduto.Controls.Add(txtValorUnit);
            gbxProduto.Controls.Add(label6);
            gbxProduto.Controls.Add(txtDescricao);
            gbxProduto.Controls.Add(txtCodBar);
            gbxProduto.Controls.Add(label5);
            gbxProduto.Controls.Add(label4);
            gbxProduto.Enabled = false;
            gbxProduto.Location = new Point(37, 227);
            gbxProduto.Name = "gbxProduto";
            gbxProduto.Size = new Size(694, 88);
            gbxProduto.TabIndex = 7;
            gbxProduto.TabStop = false;
            gbxProduto.Text = "Produto";
            // 
            // lblDescMax
            // 
            lblDescMax.AutoSize = true;
            lblDescMax.ForeColor = Color.Red;
            lblDescMax.Location = new Point(526, 70);
            lblDescMax.Name = "lblDescMax";
            lblDescMax.Size = new Size(44, 15);
            lblDescMax.TabIndex = 11;
            lblDescMax.Text = "R$ 0,00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(515, 29);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 10;
            label8.Text = "Desconto";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(515, 47);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.Size = new Size(71, 23);
            txtDescontoItem.TabIndex = 9;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextAlign = HorizontalAlignment.Right;
            // 
            // btnInserirItem
            // 
            btnInserirItem.Font = new Font("Segoe UI", 12F);
            btnInserirItem.Location = new Point(608, 38);
            btnInserirItem.Name = "btnInserirItem";
            btnInserirItem.Size = new Size(75, 35);
            btnInserirItem.TabIndex = 8;
            btnInserirItem.Text = "Inserir";
            btnInserirItem.UseVisualStyleBackColor = true;
            btnInserirItem.Click += btnInserirItem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(423, 29);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 7;
            label7.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(423, 47);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(86, 23);
            txtQuantidade.TabIndex = 6;
            txtQuantidade.Text = "1";
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(317, 47);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 5;
            txtValorUnit.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 29);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 4;
            label6.Text = "Valor Unitário";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(109, 47);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(204, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(6, 47);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(97, 23);
            txtCodBar.TabIndex = 2;
            txtCodBar.TextChanged += txtCodBar_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 29);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 1;
            label5.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 29);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 0;
            label4.Text = "Código de Barras";
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnUnidadeVenda, clnValorUnit, clnQuantidade, clnDesconto, clnValorItem, clnId });
            dgvItens.Location = new Point(35, 333);
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(740, 245);
            dgvItens.TabIndex = 8;
            dgvItens.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 14F);
            btn.Location = new Point(798, 531);
            btn.Name = "btn";
            btn.Size = new Size(157, 47);
            btn.TabIndex = 9;
            btn.Text = "Finalizar Pedido";
            btn.UseVisualStyleBackColor = true;
            // 
            // txtOutros
            // 
            txtOutros.Location = new Point(844, 437);
            txtOutros.Name = "txtOutros";
            txtOutros.Size = new Size(111, 23);
            txtOutros.TabIndex = 10;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(844, 408);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(111, 23);
            txtDesconto.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 18F);
            txtTotal.Location = new Point(798, 466);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(157, 39);
            txtTotal.TabIndex = 12;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 18F);
            txtSubTotal.Location = new Point(798, 333);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(157, 39);
            txtSubTotal.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(798, 315);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 14;
            label9.Text = "Sub Total";
            // 
            // btnExcluirItem
            // 
            btnExcluirItem.Location = new Point(676, 584);
            btnExcluirItem.Name = "btnExcluirItem";
            btnExcluirItem.Size = new Size(99, 38);
            btnExcluirItem.TabIndex = 15;
            btnExcluirItem.Text = "Excluir Item";
            btnExcluirItem.UseVisualStyleBackColor = true;
            btnExcluirItem.Click += btnExcluirItem_Click;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "Seq";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "CodBar";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.Frozen = true;
            clnUnidadeVenda.HeaderText = "Unidade";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 60;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 80;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 70;
            // 
            // clnValorItem
            // 
            clnValorItem.Frozen = true;
            clnValorItem.HeaderText = "Valor Item";
            clnValorItem.Name = "clnValorItem";
            clnValorItem.ReadOnly = true;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "Id";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Visible = false;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 655);
            Controls.Add(btnExcluirItem);
            Controls.Add(label9);
            Controls.Add(txtSubTotal);
            Controls.Add(txtTotal);
            Controls.Add(txtDesconto);
            Controls.Add(txtOutros);
            Controls.Add(btn);
            Controls.Add(dgvItens);
            Controls.Add(gbxProduto);
            Controls.Add(btnAbrirNovo);
            Controls.Add(txtVendedor);
            Controls.Add(label3);
            Controls.Add(txtNumeroPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxProduto.ResumeLayout(false);
            gbxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNumeroPedido;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtVendedor;
        private Button btnAbrirNovo;
        private GroupBox gbxProduto;
        private DataGridView dgvItens;
        private Button btn;
        private TextBox txtOutros;
        private TextBox txtDesconto;
        private TextBox txtTotal;
        private Button btnInserirItem;
        private Label label7;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private Label label6;
        private TextBox txtDescricao;
        private TextBox txtCodBar;
        private Label label5;
        private Label label4;
        private TextBox txtSubTotal;
        private Label label8;
        private TextBox txtDescontoItem;
        private Label label9;
        private Label lblDescMax;
        private Button btnExcluirItem;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnValorItem;
        private DataGridViewTextBoxColumn clnId;
    }
}