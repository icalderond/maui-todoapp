using Microsoft.EntityFrameworkCore;
using TodoApp.Shared.Models;
using TodoApp.WebAPI.Contexts;

namespace TodoApp.WebAPI.Repositories;

public class ToDoItemRepository : IToDoItemRepository
{
    public readonly TodoEFContext _context;

    public ToDoItemRepository(TodoEFContext context)
    {
        _context = context;
    }

    public async Task<ToDoItem?> Insert(ToDoItem toDoItem)
    {
        var insertedUser = await _context.ToDoItem.AddAsync(toDoItem);
        await _context.SaveChangesAsync();
        return insertedUser.Entity;
    }

    public async Task<ToDoItem?> GetById(int toDoItemId)
    {
        return await _context.ToDoItem
            .Include(x => x.Tags)
            .FirstOrDefaultAsync(x => x.Id == toDoItemId);
    }

    public async Task<List<ToDoItem>?> GetAllPersonal()
    {
        return await _context.ToDoItem
            .Include(x => x.Tags.Where(t => t.Title == "Personal"))
            .ToListAsync();
    }

    public async Task<List<ToDoItem>?> GetAll()
    {
        return await _context.ToDoItem.ToListAsync();
    }
}

public interface IToDoItemRepository
{
    Task<ToDoItem?> Insert(ToDoItem toDoItem);
    Task<ToDoItem?> GetById(int toDoItemId);
    Task<List<ToDoItem>?> GetAllPersonal();
    Task<List<ToDoItem>?> GetAll();
}