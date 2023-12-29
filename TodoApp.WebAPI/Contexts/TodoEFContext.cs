using Microsoft.EntityFrameworkCore;
using TodoApp.Shared.Models;
using TodoApp.WebAPI.Data;

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ToDoItemSeed());
    }
}