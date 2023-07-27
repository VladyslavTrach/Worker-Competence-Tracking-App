using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerCompetenceApp.Migrations
{
    /// <inheritdoc />
    public partial class AddLetterColorToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Collor",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Letter",
                table: "Projects",
                type: "nvarchar(1)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Collor",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Letter",
                table: "Projects");
        }
    }
}
