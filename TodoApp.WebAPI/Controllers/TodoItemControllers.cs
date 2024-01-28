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
        var todoItem = await _UnitOfWork._ToDoItemRepository.Delete(toDoItemId);
        if (todoItem == null) return NotFound("Item with Id specified wa not found");
        return todoItem;
    }

    [HttpGet("{todoItemId}")]
    public async Task<object?> GetById(int todoItemId)
    {
        var todoItem =await _UnitOfWork._ToDoItemRepository.GetById(todoItemId);
        if (todoItem == null) return NotFound("Item with Id specified wa not found");
        return todoItem;
    }

    [HttpGet()]
    public async Task<List<TodoItem>?> GetAll()
    {
        return await _UnitOfWork._ToDoItemRepository.GetAll();
    }
}