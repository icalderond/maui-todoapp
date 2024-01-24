using TodoApp.Shared.ModelsBase;

namespace TodoApp.Shared.Models;

public class Tag : TagBase
{
    public ICollection<TodoItem> ToDoItems { get; set; }
}