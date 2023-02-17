using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStop.Migrations
{
    public partial class RemovedNullableForLabelId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLabels_Labels_LabelId",
                table: "ProductLabels");

            migrationBuilder.AlterColumn<int>(
                name: "LabelId",
                table: "ProductLabels",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLabels_Labels_LabelId",
                table: "ProductLabels",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLabels_Labels_LabelId",
                table: "ProductLabels");

            migrationBuilder.AlterColumn<int>(
                name: "LabelId",
                table: "ProductLabels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLabels_Labels_LabelId",
                table: "ProductLabels",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
