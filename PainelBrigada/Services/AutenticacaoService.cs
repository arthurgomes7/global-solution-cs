namespace PainelBrigada.Services
{
    public class AutenticacaoService
    {
        private const string Usuario = "admin";
        private const string Senha = "admin";

        public bool Autenticar(string usuario, string senha)
        {
            return usuario == Usuario && senha == Senha;
        }
    }
}
