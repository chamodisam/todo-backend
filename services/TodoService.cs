using backend.Models;
using backend.Repositories;

namespace backend.Services;

public class TodoService : ITodoService
{
    private readonly ITodoRepository _repository;

    public TodoService(ITodoRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Todo> GetAll() => _repository.GetAll();
    public Todo? GetById(int id) => _repository.GetById(id);
    public Todo Add(Todo todo) => _repository.Add(todo);
    public bool Update(int id, Todo updated) => _repository.Update(id, updated);
    public bool Delete(int id) => _repository.Delete(id);
}
