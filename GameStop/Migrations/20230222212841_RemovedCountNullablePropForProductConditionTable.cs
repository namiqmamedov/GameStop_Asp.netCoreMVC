using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStop.Migrations
{
    public partial class RemovedCountNullablePropForProductConditionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductConditions_Conditions_ConditionId",
                table: "ProductConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductConditions_Products_ProductId",
                table: "ProductConditions");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductConditions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConditionId",
                table: "ProductConditions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductConditions_Conditions_ConditionId",
                table: "ProductConditions",
                column: "ConditionId",
                principalTable: "Conditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductConditions_Products_ProductId",
                table: "ProductConditions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductConditions_Conditions_ConditionId",
                table: "ProductConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductConditions_Products_ProductId",
                table: "ProductConditions");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductConditions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ConditionId",
                table: "ProductConditions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductConditions_Conditions_ConditionId",
                table: "ProductConditions",
                column: "ConditionId",
                principalTable: "Conditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductConditions_Products_ProductId",
                table: "ProductConditions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
