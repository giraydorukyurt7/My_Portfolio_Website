using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_Portfolio_Website.Migrations
{
    /// <inheritdoc />
    public partial class AddValueColumnFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Skills");
        }
    }
}
