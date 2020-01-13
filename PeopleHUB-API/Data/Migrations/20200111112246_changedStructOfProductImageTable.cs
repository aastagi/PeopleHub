using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class changedStructOfProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ImageOriginalName",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isProductImage",
                table: "ProductImages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isProductImage",
                table: "ProductImages");

            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "ImageOriginalName",
                table: "ProductImages",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
