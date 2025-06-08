using System.ComponentModel.DataAnnotations;

namespace SafeZone.Application.DTOs;

public class LocalizacaoDTO
{
    public int Id { get; set; }

    [Required]
    public string Cidade { get; set; } = string.Empty;

    [Required]
    public string Estado { get; set; } = string.Empty;

    [Required]
    public string Bairro { get; set; } = string.Empty;

    [Required]
    public string Rua { get; set; } = string.Empty;

    [Required]
    [RegularExpression(@"^\d{5}-?\d{3}$", ErrorMessage = "Formato de CEP inválido")]
    public string Cep { get; set; } = string.Empty;
}
