using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFinal.Server.Migrations
{
    public partial class actu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Torneos_TorneoId",
                table: "Juegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizadores_Torneos_TorneoId",
                table: "Organizadores");

            migrationBuilder.DropIndex(
                name: "IX_Organizadores_TorneoId",
                table: "Organizadores");

            migrationBuilder.DropIndex(
                name: "IX_Juegos_TorneoId",
                table: "Juegos");

            migrationBuilder.DropColumn(
                name: "TorneoId",
                table: "Organizadores");

            migrationBuilder.DropColumn(
                name: "TorneoId",
                table: "Juegos");

            migrationBuilder.AddColumn<int>(
                name: "JuegoId",
                table: "Torneos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizadorId",
                table: "Torneos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_JuegoId",
                table: "Torneos",
                column: "JuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_OrganizadorId",
                table: "Torneos",
                column: "OrganizadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Torneos_Juegos_JuegoId",
                table: "Torneos",
                column: "JuegoId",
                principalTable: "Juegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Torneos_Organizadores_OrganizadorId",
                table: "Torneos",
                column: "OrganizadorId",
                principalTable: "Organizadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Torneos_Juegos_JuegoId",
                table: "Torneos");

            migrationBuilder.DropForeignKey(
                name: "FK_Torneos_Organizadores_OrganizadorId",
                table: "Torneos");

            migrationBuilder.DropIndex(
                name: "IX_Torneos_JuegoId",
                table: "Torneos");

            migrationBuilder.DropIndex(
                name: "IX_Torneos_OrganizadorId",
                table: "Torneos");

            migrationBuilder.DropColumn(
                name: "JuegoId",
                table: "Torneos");

            migrationBuilder.DropColumn(
                name: "OrganizadorId",
                table: "Torneos");

            migrationBuilder.AddColumn<int>(
                name: "TorneoId",
                table: "Organizadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TorneoId",
                table: "Juegos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Organizadores_TorneoId",
                table: "Organizadores",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_TorneoId",
                table: "Juegos",
                column: "TorneoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_Torneos_TorneoId",
                table: "Juegos",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizadores_Torneos_TorneoId",
                table: "Organizadores",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
