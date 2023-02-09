using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStop.Migrations
{
    public partial class UpdatedProductSpecsTableChangeIntToByteForUPC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UPC",
                table: "ProductSpecs",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 12);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "UPC",
                table: "ProductSpecs",
                type: "tinyint",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 12);
        }
    }
}
