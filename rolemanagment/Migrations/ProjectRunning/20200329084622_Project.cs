using Microsoft.EntityFrameworkCore.Migrations;

namespace rolemanagment.Migrations.ProjectRunning
{
    public partial class Project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    projectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.projectID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
