using TodoApp.Shared.Models;
using TodoApp.WebAPI.Data;
using TodoApp.WebAPI.Repositories;

namespace TodoApp.WebAPI.Services;

public class ToDoItemWithTagService
{
    public readonly IUnitOfWork _UnitOfWork;

    public ToDoItemWithTagService(IUnitOfWork unitOfWork)
    {
        _UnitOfWork = unitOfWork;
    }

    public async Task<bool> Execute()
    {
        var toDoItem = new ToDoItem()
        {
            Title = "Title from controller",
            Content =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
        };

        var tags = new List<Tag>()
        {
            new Tag()
            {
                Title = "Personal",
                Description = "Personal tag",
                ToDoItem = toDoItem
            },
            new Tag()
            {
                Title = "Professional",
                Description = "Professional tag",
                ToDoItem = toDoItem
            }
        };

        await _UnitOfWork._ToDoItemRepository.Insert(toDoItem);
        await _UnitOfWork._TagRepository.Insert(tags);
        await _UnitOfWork.Save();

        return true;
    }
}