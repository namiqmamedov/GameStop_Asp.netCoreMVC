using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStop.Migrations
{
    public partial class RemovedNullableForProductLabelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLabels_Products_ProductId",
                table: "ProductLabels");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductLabels",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLabels_Products_ProductId",
                table: "ProductLabels",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLabels_Products_ProductId",
                table: "ProductLabels");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductLabels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLabels_Products_ProductId",
                table: "ProductLabels",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
