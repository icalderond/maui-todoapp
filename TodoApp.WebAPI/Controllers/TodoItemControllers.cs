using Microsoft.AspNetCore.Mvc;
using TodoApp.Shared.Models;
using TodoApp.WebAPI.Data;
using TodoApp.WebAPI.Services;

namespace TodoApp.WebAPI.Controllers;

public class TodoItemControllers : Controller
{
    public readonly ToDoItemWithTagService _ToDoItemWithTagService;
    public readonly IUnitOfWork _UnitOfWork;

    public TodoItemControllers( ToDoItemWithTagService toDoItemWithTagService, IUnitOfWork unitOfWork)
    {
        _ToDoItemWithTagService = toDoItemWithTagService;
        _UnitOfWork = unitOfWork;
    }

    [HttpPost("AddTodoItem")]
    public async Task<bool> AddTodoItem()
    { 
        return await _ToDoItemWithTagService.Execute();
    }

    [HttpGet("{todoItemId}")]
    public async Task<ToDoItem?> GetById(int todoItemId)
    {
        return await _UnitOfWork._ToDoItemRepository.GetById(todoItemId);
    }
    
    [HttpGet("GetAll")]
    public async Task<List<ToDoItem>?> GetAll() => await _UnitOfWork._ToDoItemRepository.GetAll();
    
    [HttpGet("GetAllPersonal")]
    public async Task<List<ToDoItem>?> GetAllPersonal() => await _UnitOfWork._ToDoItemRepository.GetAllPersonal();
}