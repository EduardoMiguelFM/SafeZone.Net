using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SafeZone.Application.DTOs;
using SafeZone.Application.Interfaces;
using SafeZone.Domain.Entities;
using SafeZone.Infrastructure.Data;

namespace SafeZone.API.Services;

public class AreaSeguraService : IAreaSeguraService
{
    private readonly SafeZoneContext _context;
    private readonly IMapper _mapper;

    public AreaSeguraService(SafeZoneContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AreaSeguraDTO>> GetAllAsync() =>
        _mapper.Map<IEnumerable<AreaSeguraDTO>>(await _context.AreasSeguras.ToListAsync());

    public async Task<AreaSeguraDTO> GetByIdAsync(int id) =>
        _mapper.Map<AreaSeguraDTO>(await _context.AreasSeguras.FindAsync(id));

    public async Task<AreaSeguraDTO> CreateAsync(AreaSeguraDTO dto)
    {
        var entity = _mapper.Map<AreaSegura>(dto);
        _context.AreasSeguras.Add(entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<AreaSeguraDTO>(entity);
    }

    public async Task<AreaSeguraDTO> UpdateAsync(int id, AreaSeguraDTO dto)
    {
        var entity = await _context.AreasSeguras.FindAsync(id);
        if (entity == null) return null!;
        _mapper.Map(dto, entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<AreaSeguraDTO>(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.AreasSeguras.FindAsync(id);
        if (entity == null) return false;
        _context.AreasSeguras.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}
