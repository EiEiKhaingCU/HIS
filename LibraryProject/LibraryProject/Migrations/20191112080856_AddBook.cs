using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Migrations
{
    public partial class AddBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bookId",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bookReturnId",
                table: "BookReturn",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_bookId",
                table: "Books",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReturn_bookReturnId",
                table: "BookReturn",
                column: "bookReturnId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReturn_BookReturn_bookReturnId",
                table: "BookReturn",
                column: "bookReturnId",
                principalTable: "BookReturn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Books_bookId",
                table: "Books",
                column: "bookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookReturn_BookReturn_bookReturnId",
                table: "BookReturn");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Books_bookId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_bookId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_BookReturn_bookReturnId",
                table: "BookReturn");

            migrationBuilder.DropColumn(
                name: "bookId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "bookReturnId",
                table: "BookReturn");
        }
    }
}
