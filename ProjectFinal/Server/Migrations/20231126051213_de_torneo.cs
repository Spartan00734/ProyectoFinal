using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFinal.Server.Migrations
{
    public partial class de_torneo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Torneos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaIn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Premios = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Torneos_TorneoId",
                table: "Juegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizadores_Torneos_TorneoId",
                table: "Organizadores");

            migrationBuilder.DropTable(
                name: "Torneos");

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
        }
    }
}
