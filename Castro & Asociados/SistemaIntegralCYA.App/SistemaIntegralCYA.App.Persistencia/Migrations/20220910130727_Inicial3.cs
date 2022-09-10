using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaIntegralCYA.App.Persistencia.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatosMedioPago",
                table: "Personas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DatosMedioPago",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
