namespace SafeZone.Domain.Entities;

public class Localizacao
{
    public int Id { get; set; }
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Rua { get; set; } = string.Empty;
    public string Cep { get; set; } = string.Empty;

    public ICollection<Alerta> Alertas { get; set; } = new List<Alerta>();
}
