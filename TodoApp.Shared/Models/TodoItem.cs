using System.ComponentModel.DataAnnotations;
using TodoApp.Shared.ModelsBase;

namespace TodoApp.Shared.Models;

public class TodoItem: TodoItemBase
{
    public IEnumerable<Tag?> Tags { get; set; }
}