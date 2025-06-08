using Microsoft.AspNetCore.Mvc;

namespace SafeZone.Domain.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;

    public ICollection<Alerta> Alertas { get; set; } = new List<Alerta>();
}
