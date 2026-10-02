using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresseMots.Migrations
{
    /// <inheritdoc />
    public partial class VuePArtiell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoryTags_Stories_StoryId",
                table: "StoryTags");

            migrationBuilder.DropForeignKey(
                name: "FK_StoryTags_Tags_TagId",
                table: "StoryTags");

            migrationBuilder.DropIndex(
                name: "IX_StoryTags_StoryId",
                table: "StoryTags");

            migrationBuilder.DropIndex(
                name: "IX_StoryTags_TagId",
                table: "StoryTags");

            migrationBuilder.AddColumn<int>(
                name: "StoryTagid",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoryTagid",
                table: "Stories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "StoryTagid",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                column: "StoryTagid",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_StoryTagid",
                table: "Tags",
                column: "StoryTagid");

            migrationBuilder.CreateIndex(
                name: "IX_Stories_StoryTagid",
                table: "Stories",
                column: "StoryTagid");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_StoryTags_StoryTagid",
                table: "Stories",
                column: "StoryTagid",
                principalTable: "StoryTags",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_StoryTags_StoryTagid",
                table: "Tags",
                column: "StoryTagid",
                principalTable: "StoryTags",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_StoryTags_StoryTagid",
                table: "Stories");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_StoryTags_StoryTagid",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_StoryTagid",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Stories_StoryTagid",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "StoryTagid",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "StoryTagid",
                table: "Stories");

            migrationBuilder.CreateIndex(
                name: "IX_StoryTags_StoryId",
                table: "StoryTags",
                column: "StoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoryTags_TagId",
                table: "StoryTags",
                column: "TagId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTags_Stories_StoryId",
                table: "StoryTags",
                column: "StoryId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTags_Tags_TagId",
                table: "StoryTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
