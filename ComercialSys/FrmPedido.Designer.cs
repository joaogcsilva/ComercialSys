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
            button3 = new Button();
            label7 = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            label6 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox1.SuspendLayout();
            gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // gbxProduto
            // 
            gbxProduto.Controls.Add(button3);
            gbxProduto.Controls.Add(label7);
            gbxProduto.Controls.Add(textBox10);
            gbxProduto.Controls.Add(textBox9);
            gbxProduto.Controls.Add(label6);
            gbxProduto.Controls.Add(textBox8);
            gbxProduto.Controls.Add(textBox7);
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
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(608, 38);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 8;
            button3.Text = "Inserir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(502, 29);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 7;
            label7.Text = "Quantidade";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(502, 47);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 6;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(396, 47);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 29);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 4;
            label6.Text = "Valor Unitário";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(109, 47);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(281, 23);
            textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 47);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(97, 23);
            textBox7.TabIndex = 2;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 333);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(696, 223);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(750, 510);
            button2.Name = "button2";
            button2.Size = new Size(157, 47);
            button2.TabIndex = 9;
            button2.Text = "Finalizar Pedido";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(796, 423);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(111, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(796, 394);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(111, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 18F);
            textBox6.Location = new Point(750, 452);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(157, 39);
            textBox6.TabIndex = 12;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 607);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button3;
        private Label label7;
        private TextBox textBox10;
        private TextBox textBox9;
        private Label label6;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label5;
        private Label label4;
    }
}