using backend.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TodoService>(); // Add the service

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers(); // Enable controller routing

app.Run();
