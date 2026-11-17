using PainelBrigada.Models;

namespace PainelBrigada.Forms
{
    public partial class FormQueimas : Form
    {
        private List<LocalQueima> locais = new();

        public FormQueimas()
        {
            InitializeComponent();
            AtualizarCards();
        }

        private void btnNovoLocal_Click(object sender, EventArgs e)
        {
            FormNovoLocal janela = new FormNovoLocal();
            if (janela.ShowDialog() == DialogResult.OK && janela.LocalCriado != null)
            {
                locais.Add(janela.LocalCriado);
                AtualizarCards();
            }
        }

        private void AtualizarCards()
        {
            pnlCards.Controls.Clear();
            double totalHectares = 0;

            foreach (LocalQueima local in locais)
            {
                pnlCards.Controls.Add(CriarCard(local));
                totalHectares += local.Hectares;
            }

            lblVazio.Visible = locais.Count == 0;

            string palavraLocal = locais.Count == 1 ? "local" : "locais";
            lblResumo.Text = $"{locais.Count} {palavraLocal} · {totalHectares:0.0} ha no total";
        }

        private Panel CriarCard(LocalQueima local)
        {
            Panel card = new Panel();
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Size = new Size(570, 100);
            card.Margin = new Padding(5);

            Label lblNome = new Label();
            lblNome.Text = local.Nome;
            lblNome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNome.Location = new Point(10, 8);
            lblNome.Size = new Size(430, 25);

            Label lblEndereco = new Label();
            lblEndereco.Text = local.Endereco;
            lblEndereco.Location = new Point(10, 38);
            lblEndereco.Size = new Size(430, 22);

            Label lblInfo = new Label();
            lblInfo.Text = $"{local.Hectares:0.0} ha · {local.Porte}";
            lblInfo.Location = new Point(10, 64);
            lblInfo.Size = new Size(430, 22);

            Button btnExcluir = new Button();
            btnExcluir.Text = "Excluir";
            btnExcluir.Location = new Point(460, 28);
            btnExcluir.Size = new Size(95, 40);
            btnExcluir.Click += (sender, e) => ExcluirLocal(local);

            card.Controls.Add(lblNome);
            card.Controls.Add(lblEndereco);
            card.Controls.Add(lblInfo);
            card.Controls.Add(btnExcluir);
            return card;
        }

        private void ExcluirLocal(LocalQueima local)
        {
            DialogResult resposta = MessageBox.Show("Deseja excluir este local?", "Confirmar exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                locais.Remove(local);
                AtualizarCards();
            }
        }
    }
}
