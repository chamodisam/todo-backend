using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using backend.Data;

namespace backend.Data;

public class TodoContextFactory : IDesignTimeDbContextFactory<TodoContext>
{
    public TodoContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<TodoContext>();
        optionsBuilder.UseSqlite("Data Source=todos.db");

        return new TodoContext(optionsBuilder.Options);
    }
}
