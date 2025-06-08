using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SafeZone.Application.DTOs;
using SafeZone.Application.Interfaces;
using SafeZone.Domain.Entities;
using SafeZone.Infrastructure.Data;

namespace SafeZone.API.Services;

public class AlertaService : IAlertaService
{
    private readonly SafeZoneContext _context;
    private readonly IMapper _mapper;

    public AlertaService(SafeZoneContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AlertaDTO>> GetAllAsync() =>
        _mapper.Map<IEnumerable<AlertaDTO>>(await _context.Alertas.ToListAsync());

    public async Task<AlertaDTO> GetByIdAsync(int id) =>
        _mapper.Map<AlertaDTO>(await _context.Alertas.FindAsync(id));

    public async Task<AlertaDTO> CreateAsync(AlertaDTO dto)
    {
        var entity = _mapper.Map<Alerta>(dto);
        _context.Alertas.Add(entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<AlertaDTO>(entity);
    }

    public async Task<AlertaDTO> UpdateAsync(int id, AlertaDTO dto)
    {
        var entity = await _context.Alertas.FindAsync(id);
        if (entity == null) return null!;
        _mapper.Map(dto, entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<AlertaDTO>(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Alertas.FindAsync(id);
        if (entity == null) return false;
        _context.Alertas.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}