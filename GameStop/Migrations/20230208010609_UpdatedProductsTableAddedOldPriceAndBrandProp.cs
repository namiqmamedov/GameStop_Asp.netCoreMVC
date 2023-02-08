using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStop.Migrations
{
    public partial class UpdatedProductsTableAddedOldPriceAndBrandProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Money",
                table: "Products",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "DiscountedPrice",
                table: "Products",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Products",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "OldPrice",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Products");

            migrationBuilder.AlterColumn<double>(
                name: "Money",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DiscountedPrice",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
