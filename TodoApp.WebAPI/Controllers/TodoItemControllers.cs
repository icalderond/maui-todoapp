using Microsoft.AspNetCore.Mvc;
using TodoApp.Shared.ModelRequests;
using TodoApp.Shared.Models;
using TodoApp.Shared.ModelsBase;
using TodoApp.WebAPI.Data;
using TodoApp.WebAPI.Services;

namespace TodoApp.WebAPI.Controllers;

[Route("todoitems", Name = "TodoItem")]
public class TodoItemControllers : Controller
{
    public readonly ToDoItemWithTagService _ToDoItemWithTagService;
    public readonly IUnitOfWork _UnitOfWork;

    public TodoItemControllers(ToDoItemWithTagService toDoItemWithTagService, IUnitOfWork unitOfWork)
    {
        _ToDoItemWithTagService = toDoItemWithTagService;
        _UnitOfWork = unitOfWork;
    }

    [HttpPost()]
    public async Task<bool> Add([FromBody] TodoItemRequest todoItemRequest)
    {
        return await _ToDoItemWithTagService.AddTodoItem(todoItemRequest);
    }

    [HttpDelete("{toDoItemId}")]
    public async Task<object> Remove(int toDoItemId)
    {
        return await _UnitOfWork._ToDoItemRepository.Delete(toDoItemId);
    }

    [HttpGet("{todoItemId}")]
    public async Task<TodoItem?> GetById(int todoItemId)
    {
        return await _UnitOfWork._ToDoItemRepository.GetById(todoItemId);
    }

    [HttpGet()]
    public async Task<List<TodoItem>?> GetAll()
    {
        return await _UnitOfWork._ToDoItemRepository.GetAll();
    }
}