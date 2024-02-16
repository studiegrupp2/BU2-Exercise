namespace Controllers;

using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
public interface ITodoService
{
    public void AddTodo(string title);
    public List<Todo> GetTodo();
    public void UpdateTodo(int id, bool completed);

    public void DeleteTodo(int id);
}
public class Todo
{
    private static int ID_COUNTER = 0;
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Completed { get; set; }
    public Todo(string title)
    {
        this.Title = title;
        this.Id = ID_COUNTER++;
        this.Completed = false;
    }    
}
public class TodoService : ITodoService
{
    List<Todo> todos = new List<Todo>();
    public void AddTodo(string title)
    {
        Todo todo = new Todo(title);
        todos.Add(todo);
    }

    public void DeleteTodo(int id)
    {
        for (int i = 0; i < todos.Count; i++){
            if (todos[i].Id == id)
            {
                Todo todo = todos[i];
                todos.RemoveAt(i);
                //return;
            }
        }
    }

    public List<Todo> GetTodo()
    {
        return todos;
    }

    public void UpdateTodo(int id, bool completed)
    {
        for (int i = 0; i < todos.Count; i++){
            if (todos[i].Id == id)
            {
                Todo todo = todos[i];
                todo.Completed = completed;
                return;
            }
        }
    }
}

[ApiController]
[Route("")]
public class TodoController : ControllerBase
{
    private TodoService service;
    public TodoController(TodoService todoService)
    {
        this.service = todoService;
    }

    [HttpPost]
    public IActionResult AddTodo([FromQuery] string title)
    {
        service.AddTodo(title);
        return Ok("lyckades");
    }

    [HttpGet]
    public List<Todo> GetAllTodos()
    {
        return service.GetTodo();
    }

    [HttpPut("todo/{id}")]
    public IActionResult UpdateTodo (int id, [FromQuery] bool completed)
    {
        service.UpdateTodo(id, completed);
        return Ok();
    }

    [HttpDelete("todo/{id}")]
    public IActionResult DeleteTodo(int id)
    {
        service.DeleteTodo(id);
        return Ok();
    }
}