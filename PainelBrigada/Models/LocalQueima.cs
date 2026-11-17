namespace PainelBrigada.Models
{
    public class LocalQueima
    {
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public double Hectares { get; private set; }

        public string Porte
        {
            get
            {
                if (Hectares <= 10)
                    return "Pequeno";
                if (Hectares <= 50)
                    return "Médio";
                return "Grande";
            }
        }

        public LocalQueima(string nome, string endereco, double hectares)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome é obrigatório.");
            if (string.IsNullOrWhiteSpace(endereco))
                throw new ArgumentException("O endereço é obrigatório.");
            if (hectares <= 0 || hectares > 10000)
                throw new ArgumentException("O tamanho da área deve ser maior que 0 e até 10.000 ha.");

            Nome = nome.Trim();
            Endereco = endereco.Trim();
            Hectares = hectares;
        }
    }
}
