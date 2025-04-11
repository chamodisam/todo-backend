using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<TodoService>(); // Add the service

builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlite("Data Source=todos.db"));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers(); // Enable controller routing

app.Run();
