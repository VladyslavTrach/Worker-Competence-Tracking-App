using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerCompetenceApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoneEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Workers");
        }
    }
}
