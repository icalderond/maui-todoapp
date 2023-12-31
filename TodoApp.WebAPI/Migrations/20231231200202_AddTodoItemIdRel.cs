using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTodoItemIdRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_ToDoItem_ToDoItemId",
                table: "Tag");

            migrationBuilder.AlterColumn<int>(
                name: "ToDoItemId",
                table: "Tag",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 12, 31, 14, 2, 2, 355, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2023, 12, 31, 14, 2, 2, 355, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_ToDoItem_ToDoItemId",
                table: "Tag",
                column: "ToDoItemId",
                principalTable: "ToDoItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_ToDoItem_ToDoItemId",
                table: "Tag");

            migrationBuilder.AlterColumn<int>(
                name: "ToDoItemId",
                table: "Tag",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 12, 31, 11, 23, 26, 300, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2023, 12, 31, 11, 23, 26, 300, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_ToDoItem_ToDoItemId",
                table: "Tag",
                column: "ToDoItemId",
                principalTable: "ToDoItem",
                principalColumn: "Id");
        }
    }
}
