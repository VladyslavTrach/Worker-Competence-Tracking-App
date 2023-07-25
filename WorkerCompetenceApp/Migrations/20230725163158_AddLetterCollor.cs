using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerCompetenceApp.Migrations
{
    /// <inheritdoc />
    public partial class AddLetterCollor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Collor",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Letter",
                table: "Workers",
                type: "nvarchar(1)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Collor",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Letter",
                table: "Workers");
        }
    }
}
