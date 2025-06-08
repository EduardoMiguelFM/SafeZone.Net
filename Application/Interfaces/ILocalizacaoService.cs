using SafeZone.Application.DTOs;

namespace SafeZone.Application.Interfaces;

public interface ILocalizacaoService
{
    Task<IEnumerable<LocalizacaoDTO>> GetAllAsync();
    Task<LocalizacaoDTO> GetByIdAsync(int id);
    Task<LocalizacaoDTO> CreateAsync(LocalizacaoDTO dto);
    Task<LocalizacaoDTO> UpdateAsync(int id, LocalizacaoDTO dto);
    Task<bool> DeleteAsync(int id);
}
