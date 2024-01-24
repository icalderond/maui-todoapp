using TodoApp.Shared.ModelsBase;

namespace TodoApp.Shared.ModelRequests;

public class TodoItemRequest : TodoItemBase
{
    public ICollection<TagRequest> TagRequests { get; set; }
}