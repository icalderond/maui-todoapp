using System.ComponentModel.DataAnnotations;

namespace TodoApp.Shared.Models;

public class ToDoItem
{
    public int Id { get; set; }

    [MaxLength(50)]
    public string Title { get; set; }
    
    [MaxLength(150)]
    public string Content { get; set; }

    public DateTime UpdateDate { get; set; }
}