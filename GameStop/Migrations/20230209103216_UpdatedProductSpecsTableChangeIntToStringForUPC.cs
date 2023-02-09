using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStop.Migrations
{
    public partial class UpdatedProductSpecsTableChangeIntToStringForUPC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UPC",
                table: "ProductSpecs",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 12);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UPC",
                table: "ProductSpecs",
                type: "int",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
