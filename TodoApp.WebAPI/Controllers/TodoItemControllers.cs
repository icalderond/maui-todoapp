using Microsoft.AspNetCore.Mvc;
using TodoApp.Shared.Models;
using TodoApp.WebAPI.Repositories;

namespace TodoApp.WebAPI.Controllers;

public class TodoItemControllers : Controller
{
    public readonly IToDoItemRepository _ToDoItemRepository;

    public TodoItemControllers(IToDoItemRepository toDoItemRepository)
    {
        _ToDoItemRepository = toDoItemRepository;
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

        await _ToDoItemRepository.Insert(toDoItem);
    }

    [HttpGet("{todoItemId}")]
    public async Task<ToDoItem?> Get(int todoItemId)
    {
        return await _ToDoItemRepository.GetById(todoItemId);
    }
}