using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerCompetenceApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Workers_WorkerId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_WorkerId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Workers");

            migrationBuilder.AddColumn<int>(
                name: "WorkerId",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_WorkerId",
                table: "Skills",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Workers_WorkerId",
                table: "Skills",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id");
        }
    }
}
