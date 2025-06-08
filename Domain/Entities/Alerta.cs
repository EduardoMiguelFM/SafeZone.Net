using Microsoft.AspNetCore.Mvc;

namespace SafeZone.Domain.Entities;

public enum NivelAlerta
{
    Baixo,
    Moderado,
    Alto,
    Crítico
}

public enum TipoDesastre
{
    Inundacao,
    Incendio,
    Deslizamento,
    Tempestade,
    Outro
}

public class Alerta
{
    public int Id { get; set; }
    public TipoDesastre Tipo { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public NivelAlerta Nivel { get; set; }
    public DateTime DataOcorrencia { get; set; } = DateTime.UtcNow;
    public string CondicaoClimatica { get; set; } = string.Empty;
    public double? Temperatura { get; set; }
    public int LocalizacaoId { get; set; }
    public Localizacao Localizacao { get; set; } = null!;


    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; } = null!;
}
