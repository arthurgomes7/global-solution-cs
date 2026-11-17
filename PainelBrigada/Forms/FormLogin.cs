using PainelBrigada.Services;

namespace PainelBrigada.Forms
{
    public partial class FormLogin : Form
    {
        private AutenticacaoService autenticacao = new AutenticacaoService();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Preencha usuário e senha.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!autenticacao.Autenticar(usuario, senha))
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
                return;
            }

            Hide();
            new FormQueimas().ShowDialog();
            Close();
        }
    }
}
