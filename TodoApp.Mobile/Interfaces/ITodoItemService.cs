using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.Interfaces;

public interface ITodoItemService
{
    Task<List<TodoItem>?> GetAllTodo();
}