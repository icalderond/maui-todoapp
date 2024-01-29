using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoApp.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagToDoItem_Tag_TagsId",
                table: "TagToDoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TagToDoItem_ToDoItem_ToDoItemsId",
                table: "TagToDoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagToDoItem",
                table: "TagToDoItem");

            migrationBuilder.RenameTable(
                name: "TagToDoItem",
                newName: "TagTodoItem");

            migrationBuilder.RenameIndex(
                name: "IX_TagToDoItem_ToDoItemsId",
                table: "TagTodoItem",
                newName: "IX_TagTodoItem_ToDoItemsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagTodoItem",
                table: "TagTodoItem",
                columns: new[] { "TagsId", "ToDoItemsId" });

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Title", "UpdateDate" },
                values: new object[] { "Physic assignment", new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Title", "UpdateDate" },
                values: new object[] { "Microprocessor final lab test", new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.InsertData(
                table: "ToDoItem",
                columns: new[] { "Id", "Content", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Digital Electronics lab", new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3390) },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Microprocessor final lab test", new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3390) },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "10 Home work pending", new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3400) },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Chemistry assignment", new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3400) },
                    { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Discrete Math notes", new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3400) },
                    { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Physic assignment", new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3400) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TagTodoItem_Tag_TagsId",
                table: "TagTodoItem",
                column: "TagsId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagTodoItem_ToDoItem_ToDoItemsId",
                table: "TagTodoItem",
                column: "ToDoItemsId",
                principalTable: "ToDoItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagTodoItem_Tag_TagsId",
                table: "TagTodoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TagTodoItem_ToDoItem_ToDoItemsId",
                table: "TagTodoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagTodoItem",
                table: "TagTodoItem");

            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.RenameTable(
                name: "TagTodoItem",
                newName: "TagToDoItem");

            migrationBuilder.RenameIndex(
                name: "IX_TagTodoItem_ToDoItemsId",
                table: "TagToDoItem",
                newName: "IX_TagToDoItem_ToDoItemsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagToDoItem",
                table: "TagToDoItem",
                columns: new[] { "TagsId", "ToDoItemsId" });

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Title", "UpdateDate" },
                values: new object[] { "My Note", new DateTime(2024, 1, 21, 20, 57, 16, 138, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Title", "UpdateDate" },
                values: new object[] { "My Note 2", new DateTime(2024, 1, 21, 20, 57, 16, 138, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.AddForeignKey(
                name: "FK_TagToDoItem_Tag_TagsId",
                table: "TagToDoItem",
                column: "TagsId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagToDoItem_ToDoItem_ToDoItemsId",
                table: "TagToDoItem",
                column: "ToDoItemsId",
                principalTable: "ToDoItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
