using Microsoft.EntityFrameworkCore.Migrations;

namespace GameForum.Data.Migrations
{
    public partial class AddedImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Forums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Forums");
        }
    }
}
