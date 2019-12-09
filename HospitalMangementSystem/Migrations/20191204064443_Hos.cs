using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalMangementSystemEiEiKhaing.Migrations
{
    public partial class Hos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PhoneNo",
                table: "Doctor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNo",
                table: "Doctor",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
