using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.Shared.Models;
using TodoApp.WebAPI.Contexts;

namespace TodoApp.WebAPI.Controllers;

public class TodoItemControllers : Controller
{
    public readonly TodoEFContext _context;

    public TodoItemControllers(TodoEFContext context)
    {
        _context = context;
    }

    [HttpPost("AddTodoItem")]
    public async Task AddTodoItem()
    {
        ToDoItem toDoItem = new ToDoItem()
        {
            Title = "Title from controller",
            Content =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            Tags = new List<Tag>()
            {
                new Tag() { Title = "Personal", Description = "Personal tag" },
                new Tag() { Title = "Professional", Description = "Professional tag" }
            }
        };

        await _context.ToDoItem.AddAsync(toDoItem);
        await _context.SaveChangesAsync();
    }

    [HttpGet("{todoItemId}")]
    public async Task<ToDoItem?> Get(int todoItemId)
    {
        return await _context.ToDoItem
            .Include(x=>x.Tags)
            .FirstOrDefaultAsync(x => x.Id == todoItemId);
    }
}