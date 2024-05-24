namespace ComercialSys
{
    partial class FrmLogin
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
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblSenha = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(87, 155);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(260, 155);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancela&r";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(87, 101);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(248, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(87, 38);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(87, 83);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // FrmLogin
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            CancelButton = btnCancelar;
            ClientSize = new Size(420, 216);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblSenha;
    }
}