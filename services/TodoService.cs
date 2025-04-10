using backend.Models;

namespace backend.Services;

public class TodoService
{
    private readonly List<Todo> _todos = new();

    public IEnumerable<Todo> GetAll() => _todos;

    public Todo? GetById(int id) => _todos.FirstOrDefault(t => t.Id == id);

    public Todo Add(Todo todo)
    {
        _todos.Add(todo);
        return todo;
    }

    public bool Update(int id, Todo updated)
    {
        var todo = GetById(id);
        if (todo == null) return false;

        todo.Title = updated.Title;
        todo.Completed = updated.Completed;
        return true;
    }

    public bool Delete(int id)
    {
        var todo = GetById(id);
        if (todo == null) return false;

        _todos.Remove(todo);
        return true;
    }
}
