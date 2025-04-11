using backend.Models;

namespace backend.Repositories;

public interface ITodoRepository
{
    IEnumerable<Todo> GetAll();
    Todo? GetById(int id);
    Todo Add(Todo todo);
    bool Update(int id, Todo updated);
    bool Delete(int id);
}
