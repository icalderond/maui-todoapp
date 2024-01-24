using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_ToDoItem_ToDoItemId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_ToDoItemId",
                table: "Tag");

            migrationBuilder.CreateTable(
                name: "TagToDoItem",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    ToDoItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagToDoItem", x => new { x.TagsId, x.ToDoItemsId });
                    table.ForeignKey(
                        name: "FK_TagToDoItem_Tag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagToDoItem_ToDoItem_ToDoItemsId",
                        column: x => x.ToDoItemsId,
                        principalTable: "ToDoItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 21, 20, 43, 50, 78, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2024, 1, 21, 20, 43, 50, 78, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.CreateIndex(
                name: "IX_TagToDoItem_ToDoItemsId",
                table: "TagToDoItem",
                column: "ToDoItemsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TagToDoItem");

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

            migrationBuilder.CreateIndex(
                name: "IX_Tag_ToDoItemId",
                table: "Tag",
                column: "ToDoItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_ToDoItem_ToDoItemId",
                table: "Tag",
                column: "ToDoItemId",
                principalTable: "ToDoItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
