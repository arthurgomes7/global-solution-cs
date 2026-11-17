namespace PainelBrigada.Forms
{
    partial class FormQueimas
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
            lblSubtitulo = new Label();
            btnNovoLocal = new Button();
            lblVazio = new Label();
            pnlCards = new FlowLayoutPanel();
            lblResumo = new Label();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Queimas planejadas";
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(22, 52);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(240, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Locais aguardando queima prescrita";
            //
            // btnNovoLocal
            //
            btnNovoLocal.Location = new Point(460, 20);
            btnNovoLocal.Name = "btnNovoLocal";
            btnNovoLocal.Size = new Size(160, 45);
            btnNovoLocal.TabIndex = 2;
            btnNovoLocal.Text = "Novo local";
            btnNovoLocal.UseVisualStyleBackColor = true;
            btnNovoLocal.Click += btnNovoLocal_Click;
            //
            // lblVazio
            //
            lblVazio.BackColor = Color.WhiteSmoke;
            lblVazio.ForeColor = Color.DimGray;
            lblVazio.Location = new Point(30, 100);
            lblVazio.Name = "lblVazio";
            lblVazio.Size = new Size(580, 40);
            lblVazio.TabIndex = 3;
            lblVazio.Text = "Nenhum local cadastrado. Clique em Novo local.";
            lblVazio.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pnlCards
            //
            pnlCards.AutoScroll = true;
            pnlCards.BackColor = Color.WhiteSmoke;
            pnlCards.BorderStyle = BorderStyle.FixedSingle;
            pnlCards.FlowDirection = FlowDirection.TopDown;
            pnlCards.Location = new Point(20, 90);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(600, 400);
            pnlCards.TabIndex = 4;
            pnlCards.WrapContents = false;
            //
            // lblResumo
            //
            lblResumo.AutoSize = true;
            lblResumo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumo.Location = new Point(20, 505);
            lblResumo.Name = "lblResumo";
            lblResumo.Size = new Size(170, 19);
            lblResumo.TabIndex = 5;
            lblResumo.Text = "0 locais · 0,0 ha no total";
            //
            // FormQueimas
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(640, 540);
            Controls.Add(lblVazio);
            Controls.Add(lblResumo);
            Controls.Add(pnlCards);
            Controls.Add(btnNovoLocal);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormQueimas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel da Brigada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnNovoLocal;
        private Label lblVazio;
        private FlowLayoutPanel pnlCards;
        private Label lblResumo;
    }
}
