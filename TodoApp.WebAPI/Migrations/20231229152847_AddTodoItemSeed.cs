using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoApp.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTodoItemSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDoItem",
                columns: new[] { "Id", "Content", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "My Note", new DateTime(2023, 12, 29, 9, 28, 47, 774, DateTimeKind.Local).AddTicks(5520) },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "My Note 2", new DateTime(2023, 12, 29, 9, 28, 47, 774, DateTimeKind.Local).AddTicks(5560) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
