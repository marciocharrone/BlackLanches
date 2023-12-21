using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class CorrigirDescricaoDetalhada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescricapDetalhada",
                table: "Lanches",
                newName: "DescricaoDetalhada");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescricaoDetalhada",
                table: "Lanches",
                newName: "DescricapDetalhada");
        }
    }
}
