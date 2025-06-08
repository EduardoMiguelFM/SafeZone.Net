namespace SafeZone.Domain.Entities;

public class AreaSegura
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;

    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Rua { get; set; } = string.Empty;
    public string Cep { get; set; } = string.Empty;

    public bool Acessivel { get; set; } // Acessível para pessoas com deficiência?
    public int Capacidade { get; set; } // Número de pessoas comportadas
}
