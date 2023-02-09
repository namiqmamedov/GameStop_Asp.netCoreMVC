using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStop.Migrations
{
    public partial class CreatedProductSpecsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    UPC = table.Column<byte>(maxLength: 12, nullable: false),
                    BrandName = table.Column<string>(maxLength: 255, nullable: true),
                    IsExclusive = table.Column<bool>(nullable: false),
                    NumberOfPlayers = table.Column<string>(nullable: true),
                    OnlinePlayers = table.Column<string>(nullable: true),
                    Perspective = table.Column<string>(maxLength: 60, nullable: true),
                    Genre = table.Column<string>(maxLength: 60, nullable: true),
                    IsOnline = table.Column<string>(nullable: true),
                    Franchise = table.Column<string>(nullable: true),
                    PublisherName = table.Column<string>(nullable: true),
                    DeveloperName = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    ProdLength = table.Column<string>(nullable: true),
                    ProdWidth = table.Column<string>(nullable: true),
                    ProdHeight = table.Column<string>(nullable: true),
                    UnitOfMeasure = table.Column<string>(nullable: true),
                    ProdWeight = table.Column<string>(nullable: true),
                    WeightUntOfMeasure = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSpecs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecs_ProductId",
                table: "ProductSpecs",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSpecs");
        }
    }
}
