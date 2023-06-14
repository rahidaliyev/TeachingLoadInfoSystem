using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeachingLoadInfoSystem.Migrations
{
    /// <inheritdoc />
    public partial class newmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationPlanPerGroupID",
                table: "TeachingLoadSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationPlanPerGroupID",
                table: "TeachingLoadSubjects");
        }
    }
}
