using Microsoft.EntityFrameworkCore;
using TodoApp.Shared.Models;
using TodoApp.WebAPI.Contexts;

namespace TodoApp.WebAPI.Repositories;

public class ToDoItemRepository : IToDoItemRepository
{
    private readonly TodoEFContext _context;

    public ToDoItemRepository(TodoEFContext context)
    {
        _context = context;
    }

    public async Task<TodoItem?> Insert(TodoItem toDoItem)
    {
        var insertedUser = await _context.ToDoItem.AddAsync(toDoItem);
        await _context.SaveChangesAsync();
        return insertedUser.Entity;
    }

    public async Task<TodoItem?> Delete(int toDoItemId)
    { 
        var todoItem = _context.ToDoItem.FirstOrDefault(x => x.Id == toDoItemId);
        var insertedUser =  _context.ToDoItem.Remove(todoItem);
        await _context.SaveChangesAsync();
        return insertedUser.Entity;
    }

    public async Task<TodoItem?> GetById(int toDoItemId)
    {
        return await _context.ToDoItem
            .Include(x => x.Tags)
            .FirstOrDefaultAsync(x => x.Id == toDoItemId);
    }

    public async Task<List<TodoItem>?> GetAll()
    {
        return await _context.ToDoItem
            .Include(x => x.Tags)
            .ToListAsync();
    }
}

public interface IToDoItemRepository
{
    Task<TodoItem?> Insert(TodoItem toDoItem);
    Task<TodoItem?> Delete(int toDoItemId);
    Task<TodoItem?> GetById(int toDoItemId);
    Task<List<TodoItem>?> GetAll();
}