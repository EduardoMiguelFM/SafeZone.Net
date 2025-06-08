using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SafeZone.Application.DTOs;
using SafeZone.Application.Interfaces;
using SafeZone.Domain.Entities;
using SafeZone.Infrastructure.Data;

namespace SafeZone.API.Services;

public class LocalizacaoService : ILocalizacaoService
{
    private readonly SafeZoneContext _context;
    private readonly IMapper _mapper;

    public LocalizacaoService(SafeZoneContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<LocalizacaoDTO>> GetAllAsync() =>
        _mapper.Map<IEnumerable<LocalizacaoDTO>>(await _context.Localizacoes.ToListAsync());

    public async Task<LocalizacaoDTO> GetByIdAsync(int id) =>
        _mapper.Map<LocalizacaoDTO>(await _context.Localizacoes.FindAsync(id));

    public async Task<LocalizacaoDTO> CreateAsync(LocalizacaoDTO dto)
    {
        var entity = _mapper.Map<Localizacao>(dto);
        _context.Localizacoes.Add(entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<LocalizacaoDTO>(entity);
    }

    public async Task<LocalizacaoDTO> UpdateAsync(int id, LocalizacaoDTO dto)
    {
        var entity = await _context.Localizacoes.FindAsync(id);
        if (entity == null) return null!;
        _mapper.Map(dto, entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<LocalizacaoDTO>(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Localizacoes.FindAsync(id);
        if (entity == null) return false;
        _context.Localizacoes.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}
