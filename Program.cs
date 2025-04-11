using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Services;
using backend.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlite("Data Source=todos.db"));

builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddScoped<ITodoService, TodoService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers(); // Enable controller routing

app.Run();
