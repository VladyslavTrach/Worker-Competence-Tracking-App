using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerCompetenceApp.Migrations
{
    /// <inheritdoc />
    public partial class AddProjIdDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "SkillSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "SkillSets");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Projects");
        }
    }
}
