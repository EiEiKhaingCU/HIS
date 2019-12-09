using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Migrations
{
    public partial class LBInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_BookCategory_BookCategoryId",
                table: "BookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Books_BooksIs",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BooksIs",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_BookCategory_BookCategoryId",
                table: "BookCategory");

            migrationBuilder.DropColumn(
                name: "BooksId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BooksIs",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookCategoryId",
                table: "BookCategory");

            migrationBuilder.AddColumn<int>(
                name: "BookCategoryId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books",
                column: "BookCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategory_BookCategoryId",
                table: "Books",
                column: "BookCategoryId",
                principalTable: "BookCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategory_BookCategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookCategoryId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BooksId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BooksIs",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookCategoryId",
                table: "BookCategory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BooksIs",
                table: "Books",
                column: "BooksIs");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_BookCategoryId",
                table: "BookCategory",
                column: "BookCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_BookCategory_BookCategoryId",
                table: "BookCategory",
                column: "BookCategoryId",
                principalTable: "BookCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Books_BooksIs",
                table: "Books",
                column: "BooksIs",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
