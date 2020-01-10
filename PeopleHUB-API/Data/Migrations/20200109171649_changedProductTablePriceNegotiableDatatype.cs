using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class changedProductTablePriceNegotiableDatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PriceNegotiable",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PriceNegotiable",
                table: "Products",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
