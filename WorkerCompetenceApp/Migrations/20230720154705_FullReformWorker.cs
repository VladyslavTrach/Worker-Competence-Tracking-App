using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerCompetenceApp.Migrations
{
    /// <inheritdoc />
    public partial class FullReformWorker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Workers");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Workers",
                newName: "Position");

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skills",
                table: "Workers");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Workers",
                newName: "Level");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
