using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using TodoApi.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Todo API", Description = "Keep track of thy tasks", Version = "v1" });
});
var app = builder.Build();



app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
});

app.MapGet("/todo",  () => TodoService.GetTodos());
app.MapGet("/todo/{id}", (int id) => TodoService.GetTodo(id));

app.Run();

// class TodoItem
// {
//     public int Id {get; set;}
//     public string? Item {get; set;}
//     public bool IsComplete {get; set;}
// }
