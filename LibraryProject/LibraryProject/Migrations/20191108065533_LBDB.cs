using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Migrations
{
    public partial class LBDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_BookRent_BookRentId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "BookRentId",
                table: "Students",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_BookRent_BookRentId",
                table: "Students",
                column: "BookRentId",
                principalTable: "BookRent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_BookRent_BookRentId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "BookRentId",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_BookRent_BookRentId",
                table: "Students",
                column: "BookRentId",
                principalTable: "BookRent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
