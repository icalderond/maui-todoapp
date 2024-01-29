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
            var todoItem = new TodoItem()
            {
                Title = todoItemRequest.Title,
                Content = todoItemRequest.Content,
                UpdateDate = DateTime.Now
            };

            var listOfTagRequests = todoItemRequest.TagRequests.ToList();
            var tagsForTodo = new List<Tag>();
            var tagsToInsert = new List<Tag>();

            do
            {
                tagsToInsert = new List<Tag>();
                foreach (var tagRequest in listOfTagRequests)
                {
                    var tag = await _UnitOfWork._TagRepository.GetByTitle(tagRequest.Title);
                    if (tag != null)
                    {
                        tagsForTodo.Add(tag);
                    }
                    else
                    {
                        tagsToInsert.Add(new Tag()
                        {
                            Title = tagRequest.Title,
                            Description = tagRequest.Description
                        });
                    }
                }

                if (tagsToInsert.Any())
                {
                    await _UnitOfWork._TagRepository.Insert(tagsToInsert);
                    await _UnitOfWork.Save();
                    listOfTagRequests = listOfTagRequests.Where(x => tagsForTodo.All(y => y.Title != x.Title)).ToList();
                }
            } while (tagsToInsert.Any());


            if (tagsForTodo?.Any() == true)
                tagsForTodo 
                    .ForEach(x => x.ToDoItems = new List<TodoItem>() { todoItem });
            
            await _UnitOfWork._ToDoItemRepository.Insert(todoItem);
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