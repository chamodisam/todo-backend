using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Services;
using backend.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlite("Data Source=todos.db"));

builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddScoped<ITodoService, TodoService>();

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ConfigureHttpsDefaults(httpsOptions =>
    {
        // Nothing here for local https
    });
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection(); // Redirect to https
app.MapControllers(); // Enable controller routing

app.Run();
