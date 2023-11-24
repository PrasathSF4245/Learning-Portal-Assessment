using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookDetails",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookDetails", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "bookDetails",
                columns: new[] { "BookId", "Author", "BookName", "Category", "Price", "Published", "Updated", "isDeleted" },
                values: new object[] { 1, "Sanjay", "DSP", 2, 1000, 1983, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "bookDetails",
                columns: new[] { "BookId", "Author", "BookName", "Category", "Price", "Published", "Updated", "isDeleted" },
                values: new object[] { 2, "Sam", "CNS", 1, 1000, 1993, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "bookDetails",
                columns: new[] { "BookId", "Author", "BookName", "Category", "Price", "Published", "Updated", "isDeleted" },
                values: new object[] { 3, "Ram", "AI", 0, 1000, 2013, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookDetails");
        }
    }
}
