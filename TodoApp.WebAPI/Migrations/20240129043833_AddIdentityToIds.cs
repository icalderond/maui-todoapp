using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityToIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ToDoItem",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tag",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ToDoItem",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tag",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
    }
}
