using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 12, 31, 14, 23, 43, 804, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2023, 12, 31, 14, 23, 43, 804, DateTimeKind.Local).AddTicks(5990));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
