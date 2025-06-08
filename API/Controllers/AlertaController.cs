using Microsoft.AspNetCore.Mvc;
using SafeZone.Application.DTOs;
using SafeZone.Application.Interfaces;

namespace SafeZone.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlertaController : ControllerBase
{
    private readonly IAlertaService _alertaService;

    public AlertaController(IAlertaService alertaService)
    {
        _alertaService = alertaService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AlertaDTO>>> Get() =>
        Ok(await _alertaService.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<AlertaDTO>> Get(int id)
    {
        var alerta = await _alertaService.GetByIdAsync(id);
        return alerta == null ? NotFound() : Ok(alerta);
    }

    [HttpPost]
    public async Task<ActionResult<AlertaDTO>> Post([FromBody] AlertaDTO dto)
    {
        var created = await _alertaService.CreateAsync(dto);
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<AlertaDTO>> Put(int id, [FromBody] AlertaDTO dto)
    {
        var updated = await _alertaService.UpdateAsync(id, dto);
        return updated == null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _alertaService.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}