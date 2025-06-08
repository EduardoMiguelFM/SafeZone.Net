using System.ComponentModel.DataAnnotations;

namespace SafeZone.Application.DTOs;

public class AreaSeguraDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome da área segura é obrigatório")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição é obrigatória")]
    [StringLength(300, ErrorMessage = "Máximo de 300 caracteres")]
    public string Descricao { get; set; } = string.Empty;

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

    [Required]
    public bool Acessivel { get; set; }

    [Range(1, 10000, ErrorMessage = "Capacidade deve estar entre 1 e 10000")]
    public int Capacidade { get; set; }
}
