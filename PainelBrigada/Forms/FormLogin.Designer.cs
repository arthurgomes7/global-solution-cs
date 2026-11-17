namespace PainelBrigada.Forms
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Painel da Brigada";
            //
            // lblUsuario
            //
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(30, 75);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(58, 19);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário:";
            //
            // txtUsuario
            //
            txtUsuario.Location = new Point(120, 72);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 25);
            txtUsuario.TabIndex = 2;
            //
            // lblSenha
            //
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(30, 115);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(48, 19);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            //
            // txtSenha
            //
            txtSenha.Location = new Point(120, 112);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(200, 25);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            //
            // btnEntrar
            //
            btnEntrar.Location = new Point(120, 160);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(200, 45);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            //
            // FormLogin
            //
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(360, 230);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel da Brigada - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnEntrar;
    }
}
