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
        
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ToDoItemSeed());
    }
}