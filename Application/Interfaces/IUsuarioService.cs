using SafeZone.Application.DTOs;

namespace SafeZone.Application.Interfaces;

public interface IUsuarioService
{
    Task<IEnumerable<UsuarioDTO>> GetAllAsync();
    Task<UsuarioDTO> GetByIdAsync(int id);
    Task<UsuarioDTO> CreateAsync(UsuarioDTO usuarioDto);
    Task<UsuarioDTO> UpdateAsync(int id, UsuarioDTO usuarioDto);
    Task<bool> DeleteAsync(int id);
}