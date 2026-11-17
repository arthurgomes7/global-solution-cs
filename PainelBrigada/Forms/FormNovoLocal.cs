using PainelBrigada.Models;

namespace PainelBrigada.Forms
{
    public partial class FormNovoLocal : Form
    {
        public LocalQueima? LocalCriado { get; private set; }

        public FormNovoLocal()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                LocalCriado = new LocalQueima(txtNome.Text, txtEndereco.Text, (double)numHectares.Value);
                DialogResult = DialogResult.OK;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
