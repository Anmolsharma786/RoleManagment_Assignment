using Microsoft.EntityFrameworkCore.Migrations;

namespace rolemanagment.Migrations.Salary
{
    public partial class Salary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salarys",
                columns: table => new
                {
                    salaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    Salarys = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salarys", x => x.salaryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salarys");
        }
    }
}
