using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webpage.Migrations
{
    /// <inheritdoc />
    public partial class SeedRegisterModelToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "registers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "registers",
                newName: "UserName");

            migrationBuilder.InsertData(
                table: "registers",
                columns: new[] { "Id", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "asim@gmail.com", "asim123", "asim" },
                    { 2, "mohsin@gmail.com", "mohsin123", "mohsin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "registers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "registers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "registers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "registers",
                newName: "Name");
        }
    }
}
