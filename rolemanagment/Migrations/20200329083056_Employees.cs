using Microsoft.EntityFrameworkCore.Migrations;

namespace rolemanagment.Migrations
{
    public partial class Employees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    lName = table.Column<string>(type: "varchar(20)", nullable: true),
                    gender = table.Column<string>(type: "varchar(20)", nullable: true),
                    jobId = table.Column<string>(type: "varchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
