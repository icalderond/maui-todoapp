using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityToTagTodoItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 21, 37, 59, 964, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 21, 37, 59, 964, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 21, 37, 59, 964, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 21, 37, 59, 964, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 21, 37, 59, 964, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 21, 37, 59, 964, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 21, 37, 59, 964, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 21, 37, 59, 964, DateTimeKind.Local).AddTicks(5010));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 18, 5, 0, 873, DateTimeKind.Local).AddTicks(3400));
        }
    }
}
