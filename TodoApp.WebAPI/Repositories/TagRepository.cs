using Microsoft.EntityFrameworkCore;
using TodoApp.Shared.Models;
using TodoApp.WebAPI.Contexts;

namespace TodoApp.WebAPI.Repositories;

public class TagRepository : ITagRepository
{
    public readonly TodoEFContext _context;

    public TagRepository(TodoEFContext context)
    {
        _context = context;
    }

    public async Task Insert(IList<Tag> tags)
    {
        await _context.Tag.AddRangeAsync(tags);
    }

    public async Task<Tag?> GetById(int tagId)
    {
        return await _context.Tag.FirstOrDefaultAsync(x => x.Id == tagId);
    }

    public async Task<Tag?> GetByTitle(string tagTitle)
    {
        return await _context.Tag.FirstOrDefaultAsync(x => x.Title.ToLower() == tagTitle.ToLower());
    }
}

public interface ITagRepository
{
    Task Insert(IList<Tag> tags);
    Task<Tag?> GetById(int tagId);
    Task<Tag?> GetByTitle(string tagTitle);
}