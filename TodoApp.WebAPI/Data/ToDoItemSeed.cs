using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoApp.Shared.Models;

namespace TodoApp.WebAPI.Data;

public class ToDoItemSeed : IEntityTypeConfiguration<TodoItem>
{
    public void Configure(EntityTypeBuilder<TodoItem> builder)
    {
        builder.HasData(
            new TodoItem()
            {
                Id = 1,
                Title = "Physic assignment",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            }, new TodoItem()
            {
                Id = 2,
                Title = "Microprocessor final lab test",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            }, new TodoItem()
            {
                Id = 3,
                Title = "Digital Electronics lab",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            }, new TodoItem()
            {
                Id = 4,
                Title = "Microprocessor final lab test",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            }, new TodoItem()
            {
                Id = 5,
                Title = "10 Home work pending",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            }, new TodoItem()
            {
                Id = 6,
                Title = "Chemistry assignment",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            }, new TodoItem()
            {
                Id = 7,
                Title = "Discrete Math notes",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            },
            new TodoItem()
            {
                Id = 8,
                Title = "Physic assignment",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                UpdateDate = DateTime.Now
            }
        );
    }
}