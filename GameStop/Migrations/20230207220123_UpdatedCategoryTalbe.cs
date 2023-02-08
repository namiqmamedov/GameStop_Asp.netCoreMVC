using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStop.Migrations
{
    public partial class UpdatedCategoryTalbe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "For",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "For",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "For",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "For",
                table: "Categories");
        }
    }
}
