using backend.Data;
using backend.Models;

namespace backend.Repositories;

public class TodoRepository : ITodoRepository
{
    private readonly TodoContext _context;

    public TodoRepository(TodoContext context)
    {
        _context = context;
    }

    public IEnumerable<Todo> GetAll() => _context.Todos.ToList();

    public Todo? GetById(int id) => _context.Todos.Find(id);

    public Todo Add(Todo todo)
    {
        _context.Todos.Add(todo);
        _context.SaveChanges();
        return todo;
    }

    public bool Update(int id, Todo updated)
    {
        var todo = _context.Todos.Find(id);
        if (todo == null) return false;

        todo.Title = updated.Title;
        todo.Completed = updated.Completed;
        _context.SaveChanges();
        return true;
    }

    public bool Delete(int id)
    {
        var todo = _context.Todos.Find(id);
        if (todo == null) return false;

        _context.Todos.Remove(todo);
        _context.SaveChanges();
        return true;
    }
}
