using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class changedColumnNameInProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isProductImage",
                table: "ProductImages",
                newName: "isThumbnailImage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isThumbnailImage",
                table: "ProductImages",
                newName: "isProductImage");
        }
    }
}
