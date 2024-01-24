using System.Text.Json.Serialization;
using TodoApp.Shared.ModelsBase;

namespace TodoApp.Shared.Models;

public class Tag : TagBase
{
    [JsonPropertyName("toDoItems")]
    public ICollection<TodoItem> ToDoItems { get; set; }
}