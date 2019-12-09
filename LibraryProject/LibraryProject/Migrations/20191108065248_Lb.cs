using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Migrations
{
    public partial class Lb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Books_BooksId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_BookRent_BookRentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Books_BooksId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BookRentId",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BooksId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BooksIs",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BooksIs",
                table: "Books",
                column: "BooksIs");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Books_BooksIs",
                table: "Books",
                column: "BooksIs",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_BookRent_BookRentId",
                table: "Students",
                column: "BookRentId",
                principalTable: "BookRent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Books_BooksIs",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_BookRent_BookRentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Books_BooksIs",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BooksIs",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BookRentId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BooksId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Books_BooksId",
                table: "Books",
                column: "BooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Books_BooksId",
                table: "Books",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_BookRent_BookRentId",
                table: "Students",
                column: "BookRentId",
                principalTable: "BookRent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
