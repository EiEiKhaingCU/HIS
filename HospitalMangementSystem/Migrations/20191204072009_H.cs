using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalMangementSystemEiEiKhaing.Migrations
{
    public partial class H : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Doctor_SpecialistId",
                table: "Doctor");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_SpecialistId",
                table: "Doctor",
                column: "SpecialistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Doctor_SpecialistId",
                table: "Doctor");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_SpecialistId",
                table: "Doctor",
                column: "SpecialistId",
                unique: true);
        }
    }
}
