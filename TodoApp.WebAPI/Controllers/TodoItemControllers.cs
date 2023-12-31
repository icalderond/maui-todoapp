using Microsoft.AspNetCore.Mvc;
using TodoApp.Shared.Models;
using TodoApp.WebAPI.Repositories;
using TodoApp.WebAPI.Services;

namespace TodoApp.WebAPI.Controllers;

public class TodoItemControllers : Controller
{
    public readonly IToDoItemRepository _ToDoItemRepository;
    public readonly ToDoItemWithTagService _ToDoItemWithTagService;

    public TodoItemControllers(IToDoItemRepository toDoItemRepository, ToDoItemWithTagService toDoItemWithTagService)
    {
        _ToDoItemRepository = toDoItemRepository;
        _ToDoItemWithTagService = toDoItemWithTagService;
    }

    [HttpPost("AddTodoItem")]
    public async Task AddTodoItem()
    {
        await _ToDoItemWithTagService.Execute();
    }

    [HttpGet("{todoItemId}")]
    public async Task<ToDoItem?> Get(int todoItemId)
    {
        return await _ToDoItemRepository.GetById(todoItemId);
    }
}