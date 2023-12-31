using TodoApp.WebAPI.Contexts;
using TodoApp.WebAPI.Repositories;

namespace TodoApp.WebAPI.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly TodoEFContext _context; 
    public IToDoItemRepository _ToDoItemRepository { get; }
    public ITagRepository _TagRepository { get; }

    public UnitOfWork(TodoEFContext context, IToDoItemRepository toDoItemRepository, ITagRepository tagRepository)
    {
        _context = context;
        _ToDoItemRepository = toDoItemRepository;
        _TagRepository = tagRepository;
    }

    public async Task<int> Save()
    {
       return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}

public interface IUnitOfWork : IDisposable
{ 
    public IToDoItemRepository _ToDoItemRepository { get; }
    public ITagRepository _TagRepository { get; }
    Task<int> Save();
}