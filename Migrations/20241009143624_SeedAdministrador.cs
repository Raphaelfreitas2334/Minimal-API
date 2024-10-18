using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Minimal.api.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdministrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Adiministradores",
                columns: new[] { "Id", "Email", "Perfil", "Senha" },
                values: new object[] { 1, "adm", "Adm", "123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adiministradores",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
