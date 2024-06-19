using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Services;
public record Todo
{
    public int Id { get; set; }
    public string? Item { get; set; }
    public bool Status { get; set; }
}

public class TodoService
{
    public static List<Todo> todos = [
        new Todo{Id=1, Item="Item 1", Status=false},
        new Todo{Id=2, Item="Item 2", Status=false},
        new Todo{Id=3, Item="Item 3", Status=false},
    ];


    public static List<Todo> GetTodos()
    {
        return todos;
    }

    public static Todo ? GetTodo(int id)
    {
        return todos.SingleOrDefault(todo => todo.Id == id);
    }

    public static void UpdateTodo(int id)
    {
        var index = todos.FindIndex(todo => todo.Id == id);
        // This method needs to be looked at again.
    }
}