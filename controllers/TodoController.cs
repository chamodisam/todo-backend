using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Services;

namespace backend.Controllers;

[ApiController]
[Route("api/todos")]
public class TodoController : ControllerBase
{
    private readonly TodoService _service;

    public TodoController(TodoService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var todo = _service.GetById(id);
        if (todo == null) return NotFound();
        return Ok(todo);
    }

    [HttpPost]
    public IActionResult Create(Todo todo)
    {
        var created = _service.Add(todo);
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Todo updated)
    {
        if (!_service.Update(id, updated)) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (!_service.Delete(id)) return NotFound();
        return NoContent();
    }
}
