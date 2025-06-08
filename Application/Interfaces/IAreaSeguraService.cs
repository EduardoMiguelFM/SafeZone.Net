using SafeZone.Application.DTOs;

namespace SafeZone.Application.Interfaces;

public interface IAreaSeguraService
{
    Task<IEnumerable<AreaSeguraDTO>> GetAllAsync();
    Task<AreaSeguraDTO> GetByIdAsync(int id);
    Task<AreaSeguraDTO> CreateAsync(AreaSeguraDTO dto);
    Task<AreaSeguraDTO> UpdateAsync(int id, AreaSeguraDTO dto);
    Task<bool> DeleteAsync(int id);
}
