using Microsoft.AspNetCore.Mvc;
using SafeZone.Application.DTOs;
using SafeZone.Application.Interfaces;

namespace SafeZone.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UsuarioDTO>>> Get() =>
        Ok(await _usuarioService.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<UsuarioDTO>> Get(int id)
    {
        var usuario = await _usuarioService.GetByIdAsync(id);
        return usuario == null ? NotFound() : Ok(usuario);
    }

    [HttpPost]
    public async Task<ActionResult<UsuarioDTO>> Post([FromBody] UsuarioDTO dto)
    {
        var created = await _usuarioService.CreateAsync(dto);
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UsuarioDTO>> Put(int id, [FromBody] UsuarioDTO dto)
    {
        var updated = await _usuarioService.UpdateAsync(id, dto);
        return updated == null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _usuarioService.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}