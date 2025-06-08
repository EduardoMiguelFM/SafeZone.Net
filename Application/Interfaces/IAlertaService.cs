using SafeZone.Application.DTOs;

namespace SafeZone.Application.Interfaces;

public interface IAlertaService
{
    Task<IEnumerable<AlertaDTO>> GetAllAsync();
    Task<AlertaDTO> GetByIdAsync(int id);
    Task<AlertaDTO> CreateAsync(AlertaDTO alertaDto);
    Task<AlertaDTO> UpdateAsync(int id, AlertaDTO alertaDto);
    Task<bool> DeleteAsync(int id);
}
