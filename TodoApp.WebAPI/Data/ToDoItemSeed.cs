using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoApp.Shared.Models;

namespace TodoApp.WebAPI.Data;

public class ToDoItemSeed : IEntityTypeConfiguration<ToDoItem>
{
    public void Configure(EntityTypeBuilder<ToDoItem> builder)
    {
        builder.HasData(
            new ToDoItem()
            {
                Id = 1,
                Title = "My Note",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            }, new ToDoItem()
            {
                Id = 2,
                Title = "My Note 2",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            }
        );
    }
}