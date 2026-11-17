using System.Text.Json.Serialization;

namespace PainelBrigada.Models
{
    public class LocalQueima
    {
        [JsonInclude] public string Nome { get; private set; }
        [JsonInclude] public string Endereco { get; private set; }
        [JsonInclude] public double Hectares { get; private set; }

        [JsonIgnore]
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

        // Usado também pelo JSON para recriar o objeto; as validações continuam valendo na leitura
        [JsonConstructor]
        public LocalQueima(string nome,string endereco, double hectares)
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
