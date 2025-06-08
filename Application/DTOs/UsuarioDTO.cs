using System.ComponentModel.DataAnnotations;

namespace SafeZone.Application.DTOs;

public class UsuarioDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O e-mail é obrigatório")]
    [EmailAddress(ErrorMessage = "Formato de e-mail inválido")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O telefone é obrigatório")]
    [Phone(ErrorMessage = "Formato de telefone inválido")]
    public string Telefone { get; set; } = string.Empty;

    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
}
