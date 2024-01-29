using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TodoApp.Shared.ModelsBase;

public class TodoItemBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key, Column(Order = 0)]
    [JsonPropertyName("id")] 
    public int Id { get; set; }
    
    [JsonPropertyName("title")]
    [MaxLength(50)]
    public string Title { get; set; }
    
    [JsonPropertyName("content")]
    [MaxLength(150)]
    public string Content { get; set; }

    [JsonPropertyName("updateDate")]
    public DateTime UpdateDate { get; set; }
}