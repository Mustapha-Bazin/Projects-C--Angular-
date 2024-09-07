using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class ModifierEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "mail");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "User",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "User",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "mail",
                table: "User",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "User",
                newName: "UserID");
        }
    }
}
