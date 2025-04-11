using backend.Models;

namespace backend.Services;

public interface ITodoService
{
    IEnumerable<Todo> GetAll();
    Todo? GetById(int id);
    Todo Add(Todo todo);
    bool Update(int id, Todo updated);
    bool Delete(int id);
}
