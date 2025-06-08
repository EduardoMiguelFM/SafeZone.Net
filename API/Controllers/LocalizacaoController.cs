using Microsoft.AspNetCore.Mvc;
using SafeZone.Application.DTOs;
using SafeZone.Application.Interfaces;

namespace SafeZone.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocalizacaoController : ControllerBase
{
    private readonly ILocalizacaoService _service;

    public LocalizacaoController(ILocalizacaoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LocalizacaoDTO>>> Get() =>
        Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<LocalizacaoDTO>> Get(int id)
    {
        var result = await _service.GetByIdAsync(id);
        return result == null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<LocalizacaoDTO>> Post([FromBody] LocalizacaoDTO dto)
    {
        var created = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<LocalizacaoDTO>> Put(int id, [FromBody] LocalizacaoDTO dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        return updated == null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}
