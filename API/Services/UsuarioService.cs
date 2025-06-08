using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SafeZone.Application.DTOs;
using SafeZone.Application.Interfaces;
using SafeZone.Domain.Entities;
using SafeZone.Infrastructure.Data;

namespace SafeZone.API.Services;

public class UsuarioService : IUsuarioService
{
    private readonly SafeZoneContext _context;
    private readonly IMapper _mapper;

    public UsuarioService(SafeZoneContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UsuarioDTO>> GetAllAsync() =>
        _mapper.Map<IEnumerable<UsuarioDTO>>(await _context.Usuarios.ToListAsync());

    public async Task<UsuarioDTO> GetByIdAsync(int id) =>
        _mapper.Map<UsuarioDTO>(await _context.Usuarios.FindAsync(id));

    public async Task<UsuarioDTO> CreateAsync(UsuarioDTO dto)
    {
        var entity = _mapper.Map<Usuario>(dto);
        _context.Usuarios.Add(entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<UsuarioDTO>(entity);
    }

    public async Task<UsuarioDTO> UpdateAsync(int id, UsuarioDTO dto)
    {
        var entity = await _context.Usuarios.FindAsync(id);
        if (entity == null) return null!;
        _mapper.Map(dto, entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<UsuarioDTO>(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Usuarios.FindAsync(id);
        if (entity == null) return false;
        _context.Usuarios.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}