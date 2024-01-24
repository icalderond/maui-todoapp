using TodoApp.Shared.ModelsBase;
using System.Text.Json.Serialization;

namespace TodoApp.Shared.Models;

public class TodoItem : TodoItemBase
{
    [JsonPropertyName("tags")] public IEnumerable<Tag?> Tags { get; set; }

    public IEnumerable<string> TagsString { get; set; }
}