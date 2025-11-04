using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab11MVC.Migrations
{
    /// <inheritdoc />
    public partial class v2_new_fields_active : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Acive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Acive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Acive",
                table: "Categories");
        }
    }
}
