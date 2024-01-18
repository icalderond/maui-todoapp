namespace TodoApp.Shared.Models;

public class Tag
{
    public int Id { get; set; }
    public int ToDoItemId { get; set; }
    public virtual ToDoItem ToDoItem { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}