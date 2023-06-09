using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Shop.Migrations
{
    /// <inheritdoc />
    public partial class PathAddedToUniform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Shirts");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Pants");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Uniforms",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Uniforms");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Shirts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Pants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
