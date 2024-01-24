using System.Text.Json.Serialization;

namespace TodoApp.Shared.ModelsBase;

public class TagBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("title")]
    public string Title { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
}