using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Shop.Migrations
{
    /// <inheritdoc />
    public partial class AddedPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Shirts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Pants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Shirts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pants");
        }
    }
}
