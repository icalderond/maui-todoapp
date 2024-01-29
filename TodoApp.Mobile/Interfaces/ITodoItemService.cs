using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.Mobile.Model;

namespace TodoApp.Mobile.Interfaces;

public interface ITodoItemService
{
    Task<List<TodoItemClient>?> GetAllTodo();
}