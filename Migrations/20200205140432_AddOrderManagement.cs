using Microsoft.EntityFrameworkCore.Migrations;

namespace TinyRobotsTools.Migrations
{
    public partial class AddOrderManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner = table.Column<string>(nullable: false),
                    CupSize = table.Column<int>(nullable: false),
                    CupStyle = table.Column<int>(nullable: false),
                    GlitterName = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CupSize", "CupStyle", "GlitterName", "Owner", "Status" },
                values: new object[] { 1, 0, 0, 4, "Mary", 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CupSize", "CupStyle", "GlitterName", "Owner", "Status" },
                values: new object[] { 2, 1, 2, 2, "John", 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CupSize", "CupStyle", "GlitterName", "Owner", "Status" },
                values: new object[] { 3, 2, 3, 0, "Heather", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name" },
                values: new object[] { 1, 2, "mary@test.com", "Mary" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name" },
                values: new object[] { 2, 1, "john@test.com", "John" });
        }
    }
}
