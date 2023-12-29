using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTitleOnTodoItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ToDoItem",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "ToDoItem");
        }
    }
}
