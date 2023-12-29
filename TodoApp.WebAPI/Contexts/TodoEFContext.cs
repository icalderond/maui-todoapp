using Microsoft.EntityFrameworkCore;
using TodoApp.Shared.Models;

namespace TodoApp.WebAPI.Contexts;

public class TodoEFContext : DbContext
{
    public  DbSet<ToDoItem> ToDoItem { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "conecctionString");
    }
}