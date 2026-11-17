namespace PainelBrigada.Forms
{
    partial class FormNovoLocal
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            lblHectares = new Label();
            numHectares = new NumericUpDown();
            btnOk = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numHectares).BeginInit();
            SuspendLayout();
            //
            // lblNome
            //
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 23);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(125, 19);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome / referência:";
            //
            // txtNome
            //
            txtNome.Location = new Point(180, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(260, 25);
            txtNome.TabIndex = 1;
            //
            // lblEndereco
            //
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(20, 63);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(68, 19);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço:";
            //
            // txtEndereco
            //
            txtEndereco.Location = new Point(180, 60);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(260, 25);
            txtEndereco.TabIndex = 3;
            //
            // lblHectares
            //
            lblHectares.AutoSize = true;
            lblHectares.Location = new Point(20, 103);
            lblHectares.Name = "lblHectares";
            lblHectares.Size = new Size(148, 19);
            lblHectares.TabIndex = 4;
            lblHectares.Text = "Tamanho da área (ha):";
            //
            // numHectares
            //
            numHectares.DecimalPlaces = 1;
            numHectares.Location = new Point(180, 100);
            numHectares.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numHectares.Name = "numHectares";
            numHectares.Size = new Size(120, 25);
            numHectares.TabIndex = 5;
            //
            // btnOk
            //
            btnOk.Location = new Point(180, 150);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(125, 45);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            //
            // btnCancelar
            //
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(315, 150);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 45);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            //
            // FormNovoLocal
            //
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = btnCancelar;
            ClientSize = new Size(460, 215);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(numHectares);
            Controls.Add(lblHectares);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNovoLocal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo local";
            ((System.ComponentModel.ISupportInitialize)numHectares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Label lblHectares;
        private NumericUpDown numHectares;
        private Button btnOk;
        private Button btnCancelar;
    }
}
