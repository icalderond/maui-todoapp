using TodoApp.Shared.Models;

namespace TodoApp.Mobile.Interfaces;

public interface ITodoItemService
{
    Task<List<ToDoItem>?> GetAllTodo();
}