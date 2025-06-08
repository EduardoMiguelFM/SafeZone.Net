using System.ComponentModel.DataAnnotations;

namespace SafeZone.Application.DTOs;

public class AlertaDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(200, ErrorMessage = "Máximo de 200 caracteres")]
    public string Descricao { get; set; } = string.Empty;

    [Required(ErrorMessage = "A condição climática é obrigatória")]
    public string CondicaoClimatica { get; set; } = string.Empty;

    [Range(-100, 100, ErrorMessage = "A temperatura deve estar entre -100 e 100°C")]
    public double? Temperatura { get; set; }

    [Required(ErrorMessage = "O ID do usuário é obrigatório")]
    public int UsuarioId { get; set; }

    [Required(ErrorMessage = "O ID da localização é obrigatório")]
    public int LocalizacaoId { get; set; }
}
