using TodoApp.Shared.ModelRequests;
using TodoApp.Shared.Models;
using TodoApp.WebAPI.Data;

namespace TodoApp.WebAPI.Services;

public class ToDoItemWithTagService
{
    public readonly IUnitOfWork _UnitOfWork;

    public ToDoItemWithTagService(IUnitOfWork unitOfWork)
    {
        _UnitOfWork = unitOfWork;
    }

    public async Task<bool> AddTodoItem(TodoItemRequest todoItemRequest)
    {
        try
        {
            List<Tag> tagsFromDb = new List<Tag>();
            List<Tag> tagsToDb = new List<Tag>();

            var tagsToInclude = todoItemRequest.TagRequests.Select(
                x => new Tag
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description
                }).ToList();

            foreach (var tagRequest in tagsToInclude)
            {
                var tag = await _UnitOfWork._TagRepository.GetByTitle(tagRequest.Title);
                if (tag != null)
                {
                    tagsFromDb.Add(tag);
                }
                else
                {
                    tagRequest.Id = default;
                    tagsToDb.Add(tagRequest);
                }
            }

            var todoItem = new TodoItem()
            {
                Title = todoItemRequest.Title,
                Content = todoItemRequest.Content,
                UpdateDate = DateTime.Now,
                Tags = tagsToInclude
            };

            if (tagsToDb?.Any() == true) tagsToDb.ForEach(x => x.ToDoItems = new List<TodoItem>() { todoItem });
            
            await _UnitOfWork._ToDoItemRepository.Insert(todoItem);
            if (tagsToDb?.Any() == true) 
                await _UnitOfWork._TagRepository.Insert(tagsToDb);
            await _UnitOfWork.Save();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return true;
    }
}