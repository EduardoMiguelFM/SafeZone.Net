using Microsoft.AspNetCore.Mvc;
using SafeZone.Application.DTOs;
using SafeZone.Application.Interfaces;

namespace SafeZone.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AreaSeguraController : ControllerBase
{
    private readonly IAreaSeguraService _service;

    public AreaSeguraController(IAreaSeguraService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AreaSeguraDTO>>> Get() =>
        Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<AreaSeguraDTO>> Get(int id)
    {
        var result = await _service.GetByIdAsync(id);
        return result == null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<AreaSeguraDTO>> Post([FromBody] AreaSeguraDTO dto)
    {
        var created = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<AreaSeguraDTO>> Put(int id, [FromBody] AreaSeguraDTO dto)
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
