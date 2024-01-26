using System.ComponentModel.DataAnnotations.Schema;
using TodoApp.Shared.ModelsBase;
using System.Text.Json.Serialization;

namespace TodoApp.Shared.Models;

public class TodoItem : TodoItemBase
{
    [JsonPropertyName("tags")] 
    public IEnumerable<Tag?> Tags { get; set; }

    [NotMapped]
    public IEnumerable<string> TagsString { get; set; }
}