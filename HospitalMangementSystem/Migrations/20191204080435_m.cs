using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalMangementSystemEiEiKhaing.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<double>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    Disease_History = table.Column<int>(nullable: false),
                    SymptomsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Symptoms_SymptomsId",
                        column: x => x.SymptomsId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_SymptomsId",
                table: "Patient",
                column: "SymptomsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Symptoms");
        }
    }
}
