using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xuong_C_.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "ImagePath", "Price", "PublishedDate", "Quantity", "Title" },
                values: new object[,]
                {
                    { new Guid("229cfa76-9898-4bcd-9fbf-f1252e16bfd0"), "Manh", "MM", "./images/1984.jpg", 47m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "woaa" },
                    { new Guid("64332179-411c-4754-b9be-a52744f2c007"), "Manh", "MM", "./images/catcher_in_the_rye.jpg", 40m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "woaa" },
                    { new Guid("af231b46-3dc5-4c03-bc62-2dd24eae51e6"), "Manh", "MM", "./images/moby_dick.jpg", 43m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "woaa" },
                    { new Guid("ce50c8ea-cbec-4254-9a54-7b25adcf8f2e"), "Manh", "MM", "./images/great_gatsby.jpeg", 49m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "woaa" },
                    { new Guid("ef057429-5aba-48e2-8ed9-58d15cca0ecc"), "Manh", "MM", "./images/to_kill_a_mockingbird.jpg", 45m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "woaa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("229cfa76-9898-4bcd-9fbf-f1252e16bfd0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("64332179-411c-4754-b9be-a52744f2c007"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("af231b46-3dc5-4c03-bc62-2dd24eae51e6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ce50c8ea-cbec-4254-9a54-7b25adcf8f2e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ef057429-5aba-48e2-8ed9-58d15cca0ecc"));
        }
    }
}
